using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            a.Matricula = "20202/2018";
            a.Nome = "José da Silva";
            a.Email = "jose@teste.com.br";


            Funcionario f = new Funcionario();
            f.Nome = "Maria da Silva";
            f.Email = "maria@teste.com.br";
            f.Cargo = "Secretária";
            f.Salario = 6700;

            listBox1.Items.Add(a.Matricula);
            listBox1.Items.Add(a.Nome);
            listBox1.Items.Add(a.Email);
            listBox1.Items.Add("-------------------");
            listBox1.Items.Add(f.Nome);
            listBox1.Items.Add(f.Cargo);
            listBox1.Items.Add(f.Salario);

        }
        private void EnviarEmail(CadastroBase dados)
        {
            listBox1.Items.Add($"Enviando email para {dados.Nome}");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CadastroBase a = new Aluno();
            a.Nome = "Joaquim";
            CadastroBase b = new Funcionario();
            b.Nome = "Antonio";
            EnviarEmail(a);
            EnviarEmail(b);
        }
    }
}
