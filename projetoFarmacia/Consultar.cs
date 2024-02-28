﻿using System;
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
    public partial class Consultar : Form
    {
        DAO conectar;
        public Consultar()
        {
            InitializeComponent();
            conectar= new DAO();

            ConfigurarGrid();//Prepara a tabela no meu Grid
            NomeColunas();//Preencher os nomes das colunas
            conectar.preencherVetor();//Preencher os vetores com dados do BD
            AdicionarDados();//Pegar os dados do vetor e colocar no grid
        }//fim do construtor consultar

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "rg";
           
        }//fim do método

        public void AdicionarDados()
        {
            for (int i = 0; i < conectar.RetornarContagem(); i++)
            {
                dataGridView1.Rows.Add(conectar.codigo[i], conectar.nome[i],
                    conectar.telefone[i]);
            }//fim do for

        }
        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Incluir Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Exluir Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Redimensionar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Redimensionar Linhas
            dataGridView1.ColumnCount = 5;//Quantidade de colunas   
        }//fim do configurar
      
        private void button2_Click(object sender, EventArgs e)
        {

        }//fim do botão voltar

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botão voltar
    }//fim da classe
}//fim do projeto
