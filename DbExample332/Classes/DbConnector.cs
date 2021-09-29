using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample332.Classes
{
    class DbConnector
    {
        public static DataTable Select(string sql) {
            //Генерируем строку для подключения к БД (параметры подключения)
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.201.12";
            builder.Port = 3306;
            builder.UserID = "testuser";
            builder.Password = "test234";
            builder.Database = "testuser_EFTest434";
            builder.CharacterSet = "utf8";

            //Описываем подключение к базе данных (строку подключения)
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            //Описываем комманду к БД (Запрос, Подключение)
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Создаем таблицу со значениями для записи результатов запроса
            DataTable table = new DataTable();

            //Открываем соединение
            connection.Open();
            //Загружаем результат запроса таблицу
            table.Load(command.ExecuteReader());
            //Закрываем соединение
            connection.Close();

            return table;
        }
    }
}
