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
    public partial class FormDespesas : Form
    {
        public FormDespesas()
        {
            InitializeComponent();
        }

        private void refreshData()
        {
            listView1.Items.Clear();

            
            decimal totalAmmount = 0;

            foreach (var despesa in caixa.Get_Despesas(caixa.getLastCaixa().id))
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = despesa.Id.ToString();

                listItem.SubItems.Add(despesa.comment);

                listItem.SubItems.Add("R$ " +despesa.ammount.ToString());

                totalAmmount += despesa.ammount;


                listView1.Items.Add(listItem);
            }

            lb_totalValue.Text = "R$" + totalAmmount.ToString();
        }

        private void FormDespesas_Load(object sender, EventArgs e)
        {
            refreshData();
        }



        private void btNovo_Click(object sender, EventArgs e)
        {
            pn_newDespesa.Visible = true;
            pn_newDespesa.BringToFront();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btExclui_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {



                DialogResult result = MessageBox.Show("Deseja realmente excluir a despesa" + listView1.SelectedItems[0].SubItems[1].Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
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

        private void bt_pnNewDespesa_confirma_Click(object sender, EventArgs e)
        {
            if(nud_pnNewDespesa_ammount.Value > 0)
            {
                caixa.add_Despesa(caixa.getLastCaixa().id, nud_pnNewDespesa_ammount.Value, tb_pnNewDespesa_comment.Text);
                
                pn_newDespesa.Visible=false;
                nud_pnNewDespesa_ammount.Value = 0;
                tb_pnNewDespesa_comment.ResetText();
                refreshData();
            } else
            {
                MessageBox.Show("O valor deve ser maior que 0");
            }


        }
    }
}
