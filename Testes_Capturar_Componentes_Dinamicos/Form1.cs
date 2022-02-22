using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes_Capturar_Componentes_Dinamicos
{
    public partial class Form1 : Form
    {
        private int _leftcontrol = 1;

        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    panRespostas.Controls.Clear();
        //    _alturaComponente = 1;

        //    int numeroRespostas = Convert.ToInt32(cbQuantidadeResposta.Text);

        //    for (int i = 1; i <= numeroRespostas; i++)
        //    {
        //        //Incluindo text box --------------------------->

        //        TextBox t1 = new TextBox();
        //        t1.Top = _alturaComponente * 25;
        //        t1.Left = 15;
        //        t1.Text = "TextBox" + i.ToString();
        //        t1.Name = "TextBox" + i.ToString();
        //        panRespostas.Controls.Add(t1);

        //        //incluindo check box SIM --------------------------->

        //        CheckBox chkSim = new CheckBox();
        //        chkSim.Top = _alturaComponente * 25;
        //        chkSim.Left = 148;
        //        chkSim.Text = "Sim";
        //        chkSim.Name = "chkSim" + i.ToString();
        //        panRespostas.Controls.Add(chkSim);

        //        //incluindo check box NÃO --------------------------->

        //        CheckBox chkNao = new CheckBox();
        //        chkNao.Top = _alturaComponente * 25;
        //        chkNao.Left = 260;
        //        chkNao.Text = "Nao";
        //        chkNao.Name = "chkNao" + i.ToString();
        //        panRespostas.Controls.Add(chkNao);

        //        _alturaComponente += 1;
        //    }
        //}

        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
