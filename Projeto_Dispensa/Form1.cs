﻿using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Dispensa
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

        private void fcnCarregaGrid()
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(ofd.FileName);
                string linha;
                string[] campo;

                while ((linha = sr.ReadLine()) != null)
                {
                    campo = linha.Split(';');
                    dataGridView1.Rows.Add(campo);
                }
            }
            */
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(ofd.FileName);
                string linha;                
                List<Alimento> alimentos = new List<Alimento>();
                Alimento alimento = new Alimento();

                while ((linha = sr.ReadLine()) != null)
                {
                    var line = linha;
                    var values = line.Split(';');

                    alimento.Tipo = values[0];
                    alimento.Marca = values[1];
                    alimento.Quantidade = Int32.Parse(values[2]);
                    alimento.Validade = DateTime.Parse(values[3]);
                    alimento.Tamanho = values[4];

                    alimentos.Add(alimento);
                    //listA.Add(values[]);
                }
                dataGridView1.DataSource = alimentos;

            }
        }

        

        private void butMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void butAdicionarAlimento_Click(object sender, EventArgs e)
        {
            fcnCarregaGrid();
            fcnCustomizaGrid();
        }

        private void fcnCustomizaGrid()
        {
            //var a = dataGridView1.Rows[1].Cells[2].Value;
            // txtTeste.Text = (string)a;

            int a = dataGridView1.Rows.Count;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

            }

        }
    }
}
