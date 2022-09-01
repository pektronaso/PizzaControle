using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaControle
{
    public partial class FormNewPedido : Form
    {
        public FormNewPedido()
        {
            InitializeComponent();
        }


     


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBalcao_Click(object sender, EventArgs e)
        {
            FormView.OpenSingleton("prod_ModoVenda");
            Close();
        }

        private void picIfood_Click(object sender, EventArgs e)
        {

        }

        private void picTel_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormNewPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
