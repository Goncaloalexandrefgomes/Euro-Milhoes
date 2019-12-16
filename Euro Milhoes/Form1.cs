using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euro_Milhoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private euromilhoes E = new euromilhoes();


        private void estrela(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.estrela(Convert.ToInt32(tmp.Tag.ToString())-1);
        }


        private void numeros(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.numero(Convert.ToInt32(tmp.Tag.ToString())-1);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int[] n = E.nsorteia;
            int[] s = E.esorteia;

            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();
            e1.Text = s[0].ToString();
            e2.Text = s[1].ToString();

            int nc = E.ncertos;
            int ec = E.ecertos;
            MessageBox.Show("Acertou em " + nc + " e " + ec + " estrelas");
        }
    }
}
