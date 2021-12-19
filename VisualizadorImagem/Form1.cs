using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualizadorImagem
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagemListBox.Items.AddRange(arquivos);

            // Ler do arquivo favoritos 
            string path = ObterNomeArquivoConfig();

            if (File.Exists(path))
            {
                var reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string arquivo = reader.ReadLine();
                    favoritosListBox.Items.Add(arquivo);
                }
                reader.Close();
            }
           
        }

        private void imagemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagemListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private string ObterNomeArquivoConfig()
        {
            var pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "imagensConfig.txt";
            string path = Path.Combine(pasta, arquivo);
            return path;
        }


        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Add(imagemListBox.Text);
            GravarConfiguracao();
           
        }

        private void GravarConfiguracao()
        {
            string path = ObterNomeArquivoConfig();
            var writer = new StreamWriter(path);
            foreach (string arquivo in favoritosListBox.Items)
            {
                writer.WriteLine(arquivo);
            }
            writer.Close();

        }

        private void favoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = favoritosListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            if (favoritosListBox.SelectedItem != null)
            {
                string itemSelecionado = favoritosListBox.SelectedItem.ToString();
                favoritosListBox.Items.Remove(itemSelecionado);
                GravarConfiguracao();
            }
        }
    }
}
