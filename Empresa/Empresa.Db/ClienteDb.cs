using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;

namespace Empresa.Db
{
    public class ClienteDb
    {
        public void Incluir(Cliente cliente)
        {
            //Código para incluir cliente
            string sql = @"INSERT INTO Cliente(Id,Nome,Email,Telefone) Values (@Id,@Nome,@Email,@Telefone)";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();

        }
        public void Alterar(Cliente cliente)
        {
            //Código para alterar cliente
            string sql = @"UPDATE Cliente SET Nome=@Nome,Email=@Email,Telefone=@Telefone WHERE Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();

        }

        public void Excluir(int Id)
        {
            //Código para deletar cliente
            string sql = @"DELETE Cliente WHERE Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", Id);
            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();

        }

        public Cliente ObterPorId(int Id)
        {
            string sql = @"SELECT Id, Nome, Email, Telefone FROM Cliente WHERE Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", Id);
            var cliente = new Cliente();
            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

            }
            else
            {
                cliente = null;
            }
            reader.Close();
            cn.Close();
            return cliente;

        }

        public List<Cliente> Listar()
        {

            string sql = @"SELECT Id, Nome, Email, Telefone FROM Cliente";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            List<Cliente> lista = new List<Cliente>();

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

                lista.Add(cliente);
            }

            reader.Close();
            cn.Close();
            return lista;
        }
    }
}
