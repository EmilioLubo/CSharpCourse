using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class BeerDB : DB
    {
        public BeerDB(string server, string db, string user, string password) : base(server, db, user, password)
        {
        }

        public List<Beer> GetAll()
        {
            Connect();
            List<Beer> beers= new List<Beer>();
            string query = "SELECT ID, Name, BrandID FROM BEER";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);
                int brandId = dr.GetInt32(2);
                beers.Add(new Beer(id, name, brandId));
            }
            Close();
            return beers;
        }

        public Beer Get(int id)
        {
            Connect();
            Beer beer = null;

            string query = "SELECT ID, Name, BrandID FROM BEER " +
                "WHERE ID=@id";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string name = dr.GetString(1);
                int brandId = dr.GetInt32(2);
                beer = new Beer(id, name, brandId);
            }

            Close();
            return beer;
        }

        public void Add(Beer beer)
        {
            Connect();
            string query = "INSERT INTO BEER(Name, BrandID) " +
                "Values(@name, @brandId)";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@name", beer.Name);
            cmd.Parameters.AddWithValue("@brandId", beer.BrandId);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void Edit(Beer beer)
        {
            Connect();

            string query = "UPDATE BEER SET Name=@name, BrandID=@brandId " +
                "WHERE ID=@id";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@name", beer.Name);
            cmd.Parameters.AddWithValue("@brandId", beer.BrandId);
            cmd.Parameters.AddWithValue("@id", beer.Id);
            cmd.ExecuteNonQuery();

            Close();
        }

        public void Delete(int id)
        {
            Connect();

            string query = "DELETE FROM BEER WHERE ID=@id";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            Close();
        }
    }
}
