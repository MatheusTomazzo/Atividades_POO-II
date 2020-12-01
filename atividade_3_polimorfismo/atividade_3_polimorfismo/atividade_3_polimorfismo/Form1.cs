using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_3_polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();

            pes.Nome = txtNome.Text;
            pes.Sobrenome = txtSobrenome.Text;
            pes.idade = Convert.ToInt32(txtIdade.Text);

            MessageBox.Show("Cadastro efetuado! " + "\n" + pes.Nome + " " + pes.Sobrenome + "" + "\nIdade: " + pes.idade, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
