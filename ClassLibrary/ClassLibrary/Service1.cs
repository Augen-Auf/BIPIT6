using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ServiceModel.Configuration;

namespace ClassLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public static string connectionString = @"Data Source=DESKTOP-M0UINHO\SQLSERVER;Initial Catalog=adverst;Integrated Security=True";
        public SqlConnection sqlConnection = new SqlConnection(connectionString);
        public AllData[] GetData()
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT IdO, Client, Service, Time, FORMAT(Price, 'C0') as Price, " +
                "FORMAT(Total, 'C0') as Total, FORMAT (Date, 'dd.MM.yyyy') as Date FROM [OrderView]", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<AllData> data = new List<AllData>();
            while (reader.Read())
            {
                AllData info = new AllData
                {
                    IdO = reader["IdO"].ToString(),
                    Client = reader["Client"].ToString(),
                    Service = reader["Service"].ToString(),
                    Time = reader["Time"].ToString(),
                    Price = reader["Price"].ToString(),
                    Total = reader["Total"].ToString(),
                    Date = reader["Date"].ToString(),
                };
                data.Add(info);
            }
            reader.Close();
            sqlConnection.Close();
            return data.ToArray();
        }
        public Dictionary<int, string> Clients()
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT IdC, Client FROM [Client]", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            while (reader.Read())
            {
                dict.Add(Convert.ToInt32(reader[0]), reader[1].ToString());
            }
            sqlConnection.Close();
            return dict;
        }
        public Dictionary<int, string> Services()
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT IdS, Service FROM [Service]", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            while (reader.Read())
            {
                dict.Add(Convert.ToInt32(reader[0]), reader[1].ToString());
            }
            sqlConnection.Close();
            return dict;
        }
        public void NewRec(int IdC, int IdS, int Time, DateTime Date)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO[Order] (IdC_FK, IdS_FK, Time, Date) VALUES (@IdC_FK, @IdS_FK, @Time, @Date)", sqlConnection);
            command.Parameters.AddWithValue("IdC_FK", IdC);
            command.Parameters.AddWithValue("IdS_FK", IdS);
            command.Parameters.AddWithValue("Time", Time);
            command.Parameters.AddWithValue("Date", Date);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void CountOfDBRows(string input)
        {
            Console.WriteLine("Итоговое количество записей в БД: {0}", input);
        }
        public void ResponseFromHost(string name,string port,string localPath, string uri, string scheme)
        {
            Console.WriteLine();
            Console.WriteLine("***** Host Info *****");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Port: {0}", port);
            Console.WriteLine("LocalPath: {0}", localPath);
            Console.WriteLine("Uri: {0}", uri);
            Console.WriteLine("Scheme: {0}", scheme);
            Console.WriteLine("*********************");
            Console.WriteLine();
        }
    }
}
