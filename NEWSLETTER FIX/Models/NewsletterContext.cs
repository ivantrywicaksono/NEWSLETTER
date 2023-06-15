using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace NEWSLETTER_FIX.Models
{
    internal partial class NewsletterContext
    {
        private readonly List<Newsletter> _newsletters = new();

        public List<Newsletter> Newsletters => _newsletters;

        public bool Insert(Newsletter newsletter)
        {
            bool isSuccess = false;

            using (NpgsqlConnection connection = new(connectionString))
            {

                string sql = "INSERT INTO newsletter " +
                    "(tanggal, judul, deskripsi, link_berita) " +
                    "VALUES (@news_date, @news_title, @news_description, @news_link)";

                using (NpgsqlCommand command = new(sql, connection))
                {
                    command.Parameters.Add("news_date", NpgsqlTypes.NpgsqlDbType.Date).Value = newsletter.Date;
                    command.Parameters.AddWithValue("news_title", newsletter.Title);

                    if (!string.IsNullOrWhiteSpace(newsletter.Description))
                        command.Parameters.AddWithValue("news_description", newsletter.Description);
                    else
                        command.Parameters.AddWithValue("news_description", DBNull.Value);

                    command.Parameters.AddWithValue("news_link", newsletter.Link);

                    connection.Open();

                    command.Prepare();
                    int rowsAffected = command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    connection.Close();

                    isSuccess = rowsAffected > 0;
                }

                if (isSuccess) _newsletters.Add(newsletter);
            }

            return isSuccess;
        }

        public bool ReadAll()
        {
            bool isSuccess = false;

            using (NpgsqlConnection connection = new(connectionString))
            {
                string sql = "SELECT * FROM newsletter";

                using NpgsqlCommand command = new(sql, connection);

                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();

                _newsletters.Clear();

                while (reader.Read())
                {
                    string description = General.ConvertFromDBVal<string>(reader["deskripsi"]);

                    Newsletter newsletter = new
                    (
                        DateOnly.FromDateTime((DateTime)reader["tanggal"]),
                        (string)reader["judul"],
                        description,
                        (string)reader["link_berita"],
                        (int)reader["id_newsletter"]
                    );

                    _newsletters.Add(newsletter);
                }

                isSuccess = reader.HasRows;

                connection.Close();
            }

            return isSuccess;
        }

        public Newsletter GetById(int id)
        {
            using NpgsqlConnection connection = new(connectionString);

            string sql = "SELECT * FROM newsletter WHERE news_id = @news_id";

            using NpgsqlCommand command = new(sql, connection);
            command.Parameters.Add("news_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;

            connection.Open();

            command.Prepare();
            NpgsqlDataReader reader = command.ExecuteReader();
            command.Parameters.Clear();

            reader.Read();

            string description = General.ConvertFromDBVal<string>(reader["deskripsi"]);

            Newsletter newsletter = new
            (
                (DateOnly)reader["tanggal"],
                (string)reader["judul"],
                description,
                (string)reader["link_berita"],
                (int)reader["id_newsletter"]
            );

            connection.Close();

            return newsletter;
        }

        public bool Delete(Newsletter newsletter)
        {
            bool isSuccess = false;
            using (NpgsqlConnection connection = new(connectionString))
            {
                string sql = "DELETE FROM newsletter WHERE news_id = @news_id";
                connection.Open();
                using (NpgsqlCommand command = new(sql,connection))
                {
                    command.Parameters.Add("news_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = newsletter.Id;
                    command.CommandType = System.Data.CommandType.Text;
                    int jmlDataDiHapus = command.ExecuteNonQuery();
                    if (jmlDataDiHapus > 0) isSuccess = true;
                }
            }
            return isSuccess;
        }
    }
}
