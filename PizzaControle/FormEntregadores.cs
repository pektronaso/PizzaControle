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
    public partial class FormEntregadores : Form
    {
        public FormEntregadores()
        {
            InitializeComponent();
        }

        private void refreshDate()
        {
            listView1.Items.Clear();

            label_EntregadoresCount.Text = "Entregadores: " + Database.GetEntregadores().Count;

            foreach (var entregador in Database.GetEntregadores())
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = entregador.id.ToString();

                listItem.SubItems.Add(entregador.nome);


                listView1.Items.Add(listItem);
            }
        }


        private void FormEntregadores_Load(object sender, EventArgs e)
        {
            refreshDate();
        }



        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length > 1)
            {
                MessageBox.Show(Database.add_Entregador(textBoxNome.Text));

                textBoxNome.Clear();
                panelNewEntregador.Visible = false;

                refreshDate();

            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            if (textBoxNome_altera.Text.Length > 2)
            {
                Database.alterar_Entregador(listView1.SelectedItems[0].SubItems[0].Text, textBoxNome_altera.Text);

                textBoxNome_altera.Clear();
                panelAlterar.Visible = false;
                refreshDate();
            }
        }

        

        private void buttonAlteraCancel_Click(object sender, EventArgs e)
        {
            panelAlterar.Visible = false;
        }

        private void buttonNewEntregadorCancelar_Click(object sender, EventArgs e)
        {
            panelNewEntregador.Visible = false;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            panelNewEntregador.Visible = true;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {   
                    panelAlterar.Visible = true;
                    textBoxNome_altera.Text = listView1.SelectedItems[0].SubItems[1].Text;

            }
        }

        private void btExclui_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {

                
                
                    DialogResult result = MessageBox.Show("Deseja realmente excluir o Entregador " + listView1.SelectedItems[0].SubItems[1].Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        Database.excluir_Entregador(listView1.SelectedItems[0].SubItems[0].Text);
                        refreshDate();
                    } else if (result == DialogResult.No)
                    {
                        //...
                    }
                
                

            }
        }
    }
}
