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
    public partial class FormEntradas : Form
    {
        public FormEntradas()
        {
            InitializeComponent();
        }


        private void refreshData()
        {
            listView1.Items.Clear();


            decimal totalAmmount = 0;

            foreach (var entrada in caixa.Get_Entradas(caixa.getLastCaixa().id))
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = entrada.Id.ToString();

                listItem.SubItems.Add(entrada.comment);

                listItem.SubItems.Add("R$ " + entrada.ammount.ToString());

                totalAmmount += entrada.ammount;


                listView1.Items.Add(listItem);
            }

            lb_Caixa.Text = "Caixa:" + caixa.getLastCaixa().id.ToString();

            lb_totalValue.Text = "R$" + totalAmmount.ToString();
        }


        private void btNovo_Click(object sender, EventArgs e)
        {
            pn_newEntrada.Visible = true;
            pn_newEntrada.BringToFront();
        }

        private void btExclui_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {



                DialogResult result = MessageBox.Show("Deseja realmente excluir a Entrada" + listView1.SelectedItems[0].SubItems[1].Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {

                    caixa.remove_Despesa(listView1.SelectedItems[0].SubItems[0].Text);

                    refreshData();
                }
                else if (result == DialogResult.No)
                {
                    //...
                }



            }
        }

        private void bt_pnNewEntrada_confirma_Click(object sender, EventArgs e)
        {
            if (nud_pnNewEntrada_ammount.Value > 0)
            {
                caixa.add_Entrada(caixa.getLastCaixa().id, nud_pnNewEntrada_ammount.Value, tb_pnNewEntrada_comment.Text);

                pn_newEntrada.Visible = false;
                nud_pnNewEntrada_ammount.Value = 0;
                tb_pnNewEntrada_comment.ResetText();
                refreshData();
            }
            else
            {
                MessageBox.Show("O valor deve ser maior que 0");
            }


        }
    

        private void FormEntradas_Load(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
