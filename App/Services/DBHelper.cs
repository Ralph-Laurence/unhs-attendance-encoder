using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using UNHS_Attendance_Encoder_Net48.Data_Containers;
using UNHS_Attendance_Encoder_Net48.Modals;

namespace UNHS_Attendance_Encoder_Net48.Controller_Services
{
    /// <summary>
    /// The DBHelper class handles common database operations.
    ///
    /// The Delete() method deletes a record by its ID.
    /// <list type="bullet">
    ///     <item>
    ///         <term>Find()</term>
    ///         <description>Retrieves a single record by its ID.</description>
    ///     </item>
    ///     <item>
    ///         <term>Get()</term>
    ///         <description>Retrieves all rows from a table.</description>
    ///     </item>
    ///     <item>
    ///         <term>Where()</term>
    ///         <description>Retrieves rows based on a specified condition.</description>
    ///     </item>
    ///     <item>
    ///         <term>OrderBy()</term>
    ///         <description>Retrieves rows ordered by a specified column</description>
    ///     </item>
    ///     <item>
    ///         <term>Create()</term>
    ///         <description>Inserts a new record into a table.</description>
    ///     </item>
    ///     <item>
    ///         <term>Update()</term>
    ///         <description>Updates an existing record.</description>
    ///     </item>
    /// </list>
    /// </summary>
    internal class DBHelper
    {
        public const string DbName   = "main.db";
        public string DbFolder   => Path.Combine(Constants.DataFolder, "storage");
        public string DbPath     => Path.Combine(DbFolder, DbName);
        public string ConnString => $"Data Source={DbPath}";

        public DBHelper()
        {
            Initialize();
        }

        public bool Initialize()
        {
            //MessageBox.Show(ConnString);
            try
            {
                if (!Directory.Exists(DbFolder))
                {
                    Directory.CreateDirectory(DbFolder);
                }

                if (!File.Exists(DbPath))
                {
                    ExtractDatabase();
                }

                return true;
            }
            catch (IOException ioex)
            {
                Debug.Write(ioex.Message);
                Alert.Danger($"An error is preventing {Constants.FriendlyAppName} from writing to file. Please move the application to somewhere readable and writable then try again.");
                return false;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                Alert.Danger($"An error is preventing {Constants.FriendlyAppName} from launching. Please contact the developer.");
                return false;
            }
        }

        public void ExtractDatabase()
        {
            string ResourceName = $"{Assembly.GetExecutingAssembly().GetName().Name}.Resources.{DbName}";

            // Extract the embedded resource and copy it to the target path
            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(ResourceName))
            {
                if (resourceStream != null)
                {
                    using (FileStream fileStream = new FileStream(DbPath, FileMode.Create, FileAccess.Write))
                    {
                        resourceStream.CopyTo(fileStream);
                    }
                }
                else
                {
                    throw new Exception("Embedded resource not found.");
                }
            }
        }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnString);
        }

        public T Find<T>(int id, string tableName) where T : new()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName} WHERE id = @id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            T item = new T();
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                if (!Equals(reader[prop.Name], DBNull.Value))
                                {
                                    prop.SetValue(item, reader[prop.Name], null);
                                }
                            }
                            return item;
                        }
                    }
                }
            }
            return default;
        }

        public List<T> Get<T>(string tableName) where T : new()
        {
            var list = new List<T>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName}";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = new T();
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                if (!Equals(reader[prop.Name], DBNull.Value))
                                {
                                    prop.SetValue(item, reader[prop.Name], null);
                                }
                            }
                            list.Add(item);
                        }
                    }
                }
            }
            return list;
        }

        public List<T> Where<T>(string tableName, Dictionary<string, object> conditions) where T : new()
        {
            var list = new List<T>();
            using (var connection = GetConnection())
            {
                connection.Open();
                var conditionClauses = conditions.Select(c => $"{c.Key} = @{c.Key}");
                string query = $"SELECT * FROM {tableName} WHERE {string.Join(" AND ", conditionClauses)}";
                using (var command = new SQLiteCommand(query, connection))
                {
                    foreach (var condition in conditions)
                    {
                        command.Parameters.AddWithValue($"@{condition.Key}", condition.Value);
                    }
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = new T();
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                // SQLite uses dynamic typing, which means that it doesn't
                                // have strict data types for columns. Instead, it uses storage
                                // classes like INTEGER, REAL, TEXT, BLOB, and NULL. The INTEGER
                                // storage class can hold any type of integer value, from 1-byte
                                // integers to 8-byte integers (INT64). There isn't a specific
                                // storage class for short integers in SQLite.
                                //
                                // In that case, the short integers like "user_status" is always
                                // Int64 (long) in sqlite. We need to convert it as int32 (C#)
                                //
                                //if (!Equals(reader[prop.Name], DBNull.Value))
                                //{
                                //    prop.SetValue(item, reader[prop.Name], null);
                                //}

                                var value = reader[prop.Name];

                                if (prop.PropertyType == typeof(int) && value is long)
                                {
                                    prop.SetValue(item, Convert.ToInt32(value), null);
                                }
                                else
                                {
                                    prop.SetValue(item, value, null);
                                }
                            }
                            list.Add(item);
                        }
                    }
                }
            }
            return list;
        }

        public List<T> OrderBy<T>(string tableName, string orderByColumn, bool ascending = true) where T : new()
        {
            var list = new List<T>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName} ORDER BY {orderByColumn} {(ascending ? "ASC" : "DESC")}";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = new T();
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                if (!Equals(reader[prop.Name], DBNull.Value))
                                {
                                    prop.SetValue(item, reader[prop.Name], null);
                                }
                            }
                            list.Add(item);
                        }
                    }
                }
            }
            return list;
        }

        public void Create<T>(T item, string tableName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var properties = typeof(T).GetProperties().Where(p => p.Name != "id").ToList();
                var columns = string.Join(", ", properties.Select(p => p.Name));
                var values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

                string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
                using (var command = new SQLiteCommand(query, connection))
                {
                    foreach (var prop in properties)
                    {
                        command.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(item, null) ?? DBNull.Value);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update<T>(T item, string tableName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var properties = typeof(T).GetProperties().Where(p => p.Name != "id").ToList();
                var setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));

                string query = $"UPDATE {tableName} SET {setClause} WHERE id = @id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", typeof(T).GetProperty("id")?.GetValue(item));
                    foreach (var prop in properties)
                    {
                        command.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(item, null) ?? DBNull.Value);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete<T>(int id, string tableName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = $"DELETE FROM {tableName} WHERE id = @id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
