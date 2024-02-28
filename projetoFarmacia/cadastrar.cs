using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFarmacia
{
    public partial class cadastrar : Form
    {
        
        public cadastrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(codigo.Text);
            string name = nome.Text;
            string tel = telefone.Text;
            string cid = rg.Text;
            

            bd.Inserir(cod, name, tel, cid, est);//Inserindo no BD

            //Limpando os campos
            codigo.Text = "";
            nome.Text = "";
            telefone.Text = "";
            rg.Text = "";
          

        }

        private void VoltarBotao_Click(object sender, EventArgs e)
        {

        }
    }
}
