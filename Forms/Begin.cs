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
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }

        private void button_Flegmatic_Click(object sender, EventArgs e)
        {
            Flegmatic_test newForm = new Flegmatic_test();
            newForm.Show();
            this.Hide();
        }

        private void button_Holeric_Click(object sender, EventArgs e)
        {
            Holeric_test newForm = new Holeric_test();
            newForm.Show();
            this.Hide();
        }

        private void button_Melanholik_Click(object sender, EventArgs e)
        {
            Melanholik_test newForm = new Melanholik_test();
            newForm.Show();
            this.Hide();
        }

        private void button_Sangvinic_Click(object sender, EventArgs e)
        {
            Sangvinic_test newForm = new Sangvinic_test();
            newForm.Show();
            this.Hide();
        }

        private void button_delete_results_Click(object sender, EventArgs e)
        {
            Flegmatic.Value = 0;
            Holeric.Value = 0;
            Melanholik.Value = 0;   
            Sangvinic.Value = 0;
            Pos_answer.Value = 0;
        }

        private void button_results_Click(object sender, EventArgs e)
        {
            Flegmatic.Value = (Flegmatic_sum.Value / Pos_answer.Value) * 100;
            Holeric.Value = (Holeric_sum.Value / Pos_answer.Value) * 100;
            Melanholik.Value = (Melanholik_sum.Value / Pos_answer.Value) * 100;
            Sangvinic.Value = (Sangvinic_sum.Value / Pos_answer.Value) * 100;
           
            Rezults newForm = new Rezults();
            newForm.Show();
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Begin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
