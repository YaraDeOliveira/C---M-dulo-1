using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensagem (string msg)
        {
            listBox1.Items.Add(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL SERVER
            //SqlConnection
            //      ConnectionString - config do servidor
            //      Open() e Close() - Para Abrir e Fechar a conexão
            //SqlCommand - executa comandos no banco
            //      Connection - Conexão
            //      CommandText - o que vai ser executado 
            //      ExecuteReader() - retorna dados
            //      ExecuteNonQuery() - executa comandos sem retorno (create, insert, update) 
            //      ExecuteScalar() - retorna uma unica informação
            //SqlDataReader - lê informações do banco
            //      Read()

            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=LOCALHOST\SQLEXPRESS;
                                    Initial Catalog=EmpresaDb;
                                    Integrated Security=True;";
            cn.Open();
            Mensagem("Conexão aberta");

            cn.Close();
            Mensagem("Conexão fechada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=LOCALHOST\SQLEXPRESS;
                                    Initial Catalog=EmpresaDb;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT Nome FROM Cliente";

            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nome = reader["Nome"].ToString();
                listBox1.Items.Add(nome);
            }
            reader.Close();
            cn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=LOCALHOST\SQLEXPRESS;
                                    Initial Catalog=EmpresaDb;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Cliente(Id,Nome, Email,Telefone) Values (@Id, @Nome, @Email, @Telefone)";
            cmd.Parameters.AddWithValue("@Id", 25);
            cmd.Parameters.AddWithValue("@Nome", "Joaquim da Silva");
            cmd.Parameters.AddWithValue("@Telefone", "55++ (11) 5855-6777");
            cmd.Parameters.AddWithValue("@Email", "joaquim@teste.com");

            cn.Open();

            Mensagem("Conexão Aberta");
            int total =  cmd.ExecuteNonQuery();
            Mensagem("Registro Incluido");

            cn.Close();
            Mensagem("Conexão Fechada");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=LOCALHOST\SQLEXPRESS;
                                    Initial Catalog=EmpresaDb;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Cliente SET Nome=@Nome WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 25);
            cmd.Parameters.AddWithValue("@Nome", "Joaquim Silva Souza");
           
            cn.Open();

            int total = cmd.ExecuteNonQuery();

            cn.Close();
            Mensagem("Registro alterado com sucesso");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=LOCALHOST\SQLEXPRESS;
                                    Initial Catalog=EmpresaDb;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE Cliente WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 25);
          
            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();
            Mensagem("Registro deletado com sucesso");
        }
    }
}
