using PizzaControle.Models;
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

        private void RefreshCaixa()
        {
            if (Database.ExistsOpenCaixa())
            {

                caixa cx = caixa.getLastCaixa();


                lb_code.Text = cx.id.ToString();
                lb_status.Text = "ABERTO";
                lb_status.ForeColor = Color.LimeGreen;
                lb_Ammount.Text = "R$:" + (cx.initial_ammount - cx.Get_Total_Despesas());
                lb_OpenAt.Text = cx.created_At.ToString();

                lb_despesas.Text = "R$:" + cx.Get_Total_Despesas();



                bt_AbrirCaixa.Enabled = false;
                bt_FecharCaixa.Enabled = true;

            }
            else
            {

                bt_AbrirCaixa.Enabled = true;
                bt_FecharCaixa.Enabled = false;
                lb_status.Text = "FECHADO";
                lb_status.ForeColor = Color.Red;
            }
        }

        private void Disable_Panels() {

            pn_AbrirCaixa.Visible = false;
            pn_FecharCaixa.Visible = false;            
            
        }

        private void Enable_pnAbrirCaixa() {

            Disable_Panels();
            
            pn_AbrirCaixa.Visible = true;
            pn_AbrirCaixa.BringToFront();

        }

        private void Enable_pnFecharCaixa() {

            Disable_Panels();
            
            pn_FecharCaixa.Visible = true;
            pn_FecharCaixa.BringToFront();
        }

        private void FormCaixa_Load(object sender, EventArgs e)
        {
            RefreshCaixa();
        }

        private void bt_AbrirCaixa_Click(object sender, EventArgs e)
        {
            Enable_pnAbrirCaixa();
        }

        private void bt_FecharCaixa_Click(object sender, EventArgs e)
        {
            Enable_pnFecharCaixa();
        }





        private void bt_pnAbrirCaixa_Click(object sender, EventArgs e)
        {
            if (!Database.ExistsOpenCaixa())
            {
                caixa.OpenCaixa(numericUpDown_AmmountInCaixa.Value);
            }

            Disable_Panels();
            RefreshCaixa();
        }

        private void bt_pnFecharCaixa_Click(object sender, EventArgs e)
        {
            caixa cx = caixa.getLastCaixa();
            cx.closed_ammount = numericUpDown_FecharAmmount.Value;
            caixa.CloseCaixa(cx);

            lb_code.Text = "000";
            lb_movimentacao.Text = "R$0,00";
            lb_Ammount.Text = "R0,00";
            lb_despesas.Text = "R$0,00";
            lb_entradas.Text = "R$0,00";
            lb_OpenAt.Text = "00/00/00";
            Disable_Panels();
            RefreshCaixa();
        }
    }
}
