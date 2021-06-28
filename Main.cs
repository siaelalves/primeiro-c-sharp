using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void cmdPr_Click(object sender, EventArgs e)
        {
            string Nome = "Siael Alves de Carvalho";
            byte Idade = 21;
            DateTime ano=new DateTime(1993,3,11);
            bool Homem = true;
            txtNm.Text = Nome;
            txtId.Value = Idade;
            txtNasc.Value = ano;
            if (Homem=true)
            {
                txtSx.Text="Masculino";
            }
            else
            {
                txtSx.Text="Feminino";
            }
        }
    }
}
