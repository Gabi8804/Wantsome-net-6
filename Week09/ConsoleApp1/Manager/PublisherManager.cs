using Simple_PublisherApp.Entities;
using Simple_PublisherApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Simple_PublisherApp.Manager
{
    class PublisherManager : IPublisherManager
    {
        private string connectionstring;

        public PublisherManager(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public int Create(Publisher publisher)
        {
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var commandText = "insert into Publisher values (@idParam, @nameParam) ";
                var command = new SqlCommand(commandText);


                var idParamObject = new SqlParameter("idParam", publisher.PublisherId);
                var nameParamObject = new SqlParameter("nameParam", publisher.Name);

                command.Parameters.Add(idParamObject);
                command.Parameters.Add(nameParamObject);

                command.Connection = connection;

                var result = command.ExecuteNonQuery();
                return result;
            }
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Publisher Read(int id)
        {

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                var commandText = "select * from Publisher where PubliserId = @idParam) ";
                var command = new SqlCommand(commandText);


                var idParamObject = new SqlParameter("idParam", id);

                command.Parameters.Add(idParamObject);

                command.Connection = connection;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        var publisherId = reader[0];
                        var name = reader[1];

                        return new Publisher
                        {
                            PublisherId = int.Parse(publisherId.ToString()),
                            Name = name.ToString()
                        };
                    }
                    else
                    {
                        throw new InvalidOperationException($"Publisher with id: {id} does not exist");
                    }
                }

            }

        }

        public int Update(Publisher publisher)
        {
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                var commandText = "update Publisher set name = @nameParam where PublisherId = @idParam";
                var command = new SqlCommand(commandText);

                var idParam = new SqlParameter("idParam", publisher.PublisherId);
                var nameParam = new SqlParameter("nameParam", publisher.Name);

                command.Parameters.Add(idParam);
                command.Parameters.Add(nameParam);

                command.Connection = connection;

                var result = command.ExecuteNonQuery();
                return result;

            }
        }
    }
}
