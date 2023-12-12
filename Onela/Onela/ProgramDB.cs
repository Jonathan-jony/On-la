using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Onela
{
    public class DBConnector
    {
        //The collection of results
        private static List<string> customers = new List<string>();

        public List<Contact> ExecuteQuerySelect()
        {
            List<Contact> queryResults = new List<Contact>();

            //TODO Improvement - use an external file to store sensitive data
            string connString = "server=localhost;user=root;database=onela;port=3306;password=Pa$$w0rd;";

            //prepare the connection
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            //prepare the query
            //TODO Improvement - Using @parameter and value to build the query
            //TODO Improvement - https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlparametercollection.addwithvalue?view=dotnet-plat-ext-7.0
            string query = "SELECT * FROM contact";

            //set and execute the query 
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
           
            //retrieve values
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                {

                Contact contact = new Contact(
                    Firstname: reader.GetString(1),
                    Lastname: reader.GetString(2),
                    numberPhone: reader.GetString(3)
                    );

                queryResults.Add(contact);
            }
            return queryResults;
        }
        public bool ExecuteQueryInsert(Contact contact)
        {
            //TODO Improvement - use an external file to store sensitive data
            string connString = "server=localhost;user=root;database=onela;port=3306;password=Pa$$w0rd;";

            //prepare the connection
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            //prepare the query
            //TODO Improvement - Using @parameter and value to build the query
            //TODO Improvement - https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlparametercollection.addwithvalue?view=dotnet-plat-ext-7.0
            string query = "INSERT INTO contact (firstname, lastname, phone_number) VALUES ('" + contact.Firstname + "', '" + contact.Lastname + "', '" + contact.Numberphone + "');";

            //set and execute the query 
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}