using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNett
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server= (localdb)\mssqllocaldb;initial catalog=Zamazingo;integrated security=true");
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Urunler", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Stok = Convert.ToInt32(reader["Stok"]),
                    Fiyat = Convert.ToDecimal(reader["Fiyat"])

                };
                products.Add(product);


            }
            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Urunler values(@name,@fiyat,@stok)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@Fiyat", product.Fiyat);
            command.Parameters.AddWithValue("@Stok", product.Stok);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(Product product) 
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Urunler set Name=@name, Fiyat=@Fiyat, Stok= @Stok where Id = @id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@Fiyat", product.Fiyat);
            command.Parameters.AddWithValue("@Stok", product.Stok);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Urunler where Id = @id", _connection);
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
