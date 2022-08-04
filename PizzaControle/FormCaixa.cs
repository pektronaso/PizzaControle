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
    public partial class FormCaixa : Form
    {
        public FormCaixa()
        {
            InitializeComponent();
        }



        private void FormCaixa_Load(object sender, EventArgs e)
        {


            if (database.ExistsOpenCaixa())
            {
                
                caixa cx = database.GetLastCaixa();

                if(cx.id > 0)
                {
                    lb_code.Text = cx.code;
                    
                }

                bt_AbrirCaixa.Enabled = false;
                bt_FecharCaixa.Enabled = true;
            } else
            {
                bt_AbrirCaixa.Enabled = true;
                bt_FecharCaixa.Enabled = false;
            }

        }
    }
}
