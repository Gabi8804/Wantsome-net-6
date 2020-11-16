using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Week09_SqlConn
{
    class Program
    {
        static void Main(string[] args)
        {
            var Connectionstring = @"Server=NB-GPOPA\SQLEXPRESS;Database=Week09;Trusted_Connection=True;";


            using (var connection = new SqlConnection(Connectionstring))
            {
                connection.Open();


                try
                {
                    var id = int.Parse(Console.ReadLine());
                    var name = Console.ReadLine();

                    var commandText = "insert into Publisher values (@idParam, @nameParam) ";
                    var command = new SqlCommand(commandText);


                    var idParamObject = new SqlParameter("idParam", id);
                    var nameParamObject = new SqlParameter("nameParam", name);

                    command.Parameters.Add(idParamObject);
                    command.Parameters.Add(nameParamObject);

                    command.Connection = connection;

                    var result = command.ExecuteNonQuery();
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }

        
        }
    }
}
