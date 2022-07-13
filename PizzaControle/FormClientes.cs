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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void clearPanelNew(){
            tb_novo_nome.Clear();
            tb_novo_endereco.Clear();            
            tb_novo_numero.Clear();
            tb_novo_referencia.Clear();
            tb_novo_telefone.Clear();
            }

        private void refreshDate()
        {
            listView1.Items.Clear();

            //label_EntregadoresCount.Text = "Entregadores: " + database.GetEntregadores().Count;

            foreach (var cliente in database.GetClientes())
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = cliente.id.ToString();

                listItem.SubItems.Add(cliente.nome);

                listItem.SubItems.Add(cliente.endereço);

                listItem.SubItems.Add(cliente.numero.ToString());
                
                listItem.SubItems.Add(cliente.referencia);

                listItem.SubItems.Add(cliente.telefone);



                listView1.Items.Add(listItem);
            }
        }


        private void FormClientes_Load(object sender, EventArgs e)
        {
            refreshDate();
        }

        

        private void btNovo_Click(object sender, EventArgs e)
        {
            panelNovo.Visible = true;
        }

        private void button_novo_cancela_Click(object sender, EventArgs e)
        {
            clearPanelNew();
            panelNovo.Visible = false;
        }




        private void bt_novoSalvar_Click(object sender, EventArgs e)
        {
            if (tb_novo_nome.Text.Length     < 2 || 
                tb_novo_endereco.Text.Length < 2 ||
                tb_novo_numero.Text.Length   < 1 ||
                tb_novo_telefone.Text.Length < 11 )
            {
                MessageBox.Show("Por favor preencha todos os campos");
            } else
            {

                cliente cliente = new cliente();

                cliente.nome = tb_novo_nome.Text;
                cliente.endereço = tb_novo_endereco.Text;
                cliente.numero = Convert.ToInt32(tb_novo_numero.Text);
                cliente.referencia = tb_novo_referencia.Text;
                cliente.telefone = tb_novo_telefone.Text;

                var result = database.add_Cliente(cliente);

                MessageBox.Show(result);

                
                panelNovo.Visible = false;

                clearPanelNew();
                refreshDate();
            }



        }

        private void tb_novo_numero_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_novo_numero.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor coloque apenas numeros.");
                tb_novo_numero.Text = tb_novo_numero.Text.Remove(tb_novo_numero.Text.Length - 1);
            }
        }

        private void btExclui_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {



                DialogResult result = MessageBox.Show("Deseja realmente excluir o cliente " + listView1.SelectedItems[0].SubItems[1].Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    database.excluir_Cliente(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshDate();
                }
                else if (result == DialogResult.No)
                {
                    //...
                }



            }
        }
    }
}
