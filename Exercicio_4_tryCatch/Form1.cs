using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_2_heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

                    

        private void btnOk_Click(object sender, EventArgs e)
            {
            try
            {
                Cadastro cad = new Cadastro();

                cad.Nome = txtNome.Text;
                cad.Logradouro = txtEndereco.Text;
                cad.Numero = Convert.ToInt32(txtNumero.Text);
                cad.Cidade = txtCidade.Text;
                cad.Bairro = txtBairro.Text;
                cad.Idade = Convert.ToInt32(txtIdade.Text);

                MessageBox.Show(cad.Nome + " \n" + "\n" + cad.Idade + " \n" + cad.Logradouro + " \n" + cad.Numero + "\n" + cad.Bairro + "\n" + cad.Cidade, "Cadastro Realizado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {

                if(txtNome.Text.Length == 0 || txtEndereco.Text.Length == 0 || txtIdade.Text.Length == 0 || txtCidade.Text.Length == 0 || txtNumero.Text.Length == 0)
                {
                    MessageBox.Show("Preencha todos os campos da tela", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

         


        }
    }
}
