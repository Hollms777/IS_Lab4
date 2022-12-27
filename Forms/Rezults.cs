using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Lab4
{
    public partial class Rezults : Form
    {
        public Rezults()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Begin newForm = new Begin();
            newForm.Show();
            this.Hide();
        }

        private void Rezults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Rezults_Load(object sender, EventArgs e)
        {
            label6.Text =  Flegmatic.Value.ToString();
            label7.Text = Holeric.Value.ToString();
            label8.Text = Melanholik.Value.ToString();
            label9.Text = Sangvinic.Value.ToString();
        }
    }
}
