using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace CinemaManagment.DapperReport
{
    public class Report
    {
        private readonly string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CinemaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

        public IEnumerable<MovieDapper> GetMovieTickets()
        {
            string sql = @"SELECT M.Title,M.Year,M.Genre,T.MovieId,T.Price
                            FROM Movies AS M
                            INNER JOIN Tickets AS T
                            ON M.Id=T.MovieId";

            using (var connection= new SqlConnection(connectionString))
            {
                return connection.Query<MovieDapper, TicketDapper, MovieDapper>(sql, (m, t) =>
                {
                    m.Tickets.Add(t);
                    t.Movie = m;
                    return m;
                }, splitOn: nameof(TicketDapper.MovieId));

                }
            }
        }
    }

