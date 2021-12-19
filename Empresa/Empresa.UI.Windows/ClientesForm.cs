using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.Db;
using Empresa.Models;

namespace Empresa.UI.Windows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;
            novoButton.Visible = true;
            alterarButton.Visible = true;
            excluirButton.Visible = true;
            sairButton.Visible = true;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarIncluirButton.Visible = false;
            voltarButton.Visible = false;

            var db = new ClienteDb();
            listaDataGridView.DataSource = db.Listar();
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = false;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.RowHeadersVisible = false;
            listaDataGridView.EnableHeadersVisualStyles = false;

            listaDataGridView.Columns["Id"].Width = 50;
        }
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();

            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarIncluirButton.Visible = true;

            LimparFicha();
        }

        private void LimparFicha()
        {
            idTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
            telefoneTextBox.Clear();

            idTextBox.Focus();
        }
        private void ExibirFicha()
        {
            fichaPanel.Visible = true;
            fichaPanel.Dock = DockStyle.Fill;
            listaDataGridView.Visible = false;

            novoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarIncluirButton.Visible = true;
            voltarButton.Visible = true;
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void confirmarIncluirButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            var db = new ClienteDb();
            db.Incluir(cliente);

            ExibirGrid();
        }

     
        private void alterarButton_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente) listaDataGridView.CurrentRow.DataBoundItem;
            idTextBox.Text = cliente.Id.ToString();
            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telefoneTextBox.Text = cliente.Telefone;

            ExibirFicha();

            confirmarAlterarButton.Visible = true;
            confirmarExcluirButton.Visible = false;
            confirmarIncluirButton.Visible = false;
            
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            var db = new ClienteDb();

            db.Alterar(cliente);

            ExibirGrid();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;
            idTextBox.Text = cliente.Id.ToString();
            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telefoneTextBox.Text = cliente.Telefone;

            ExibirFicha();

            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = true;
            confirmarIncluirButton.Visible = false;
        }

        private void confirmarExcluirButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            var db = new ClienteDb();

            db.Excluir(cliente.Id);

            ExibirGrid();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
