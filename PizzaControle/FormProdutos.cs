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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }




        private void refreshDate(string tipo)
        {
            listView1.Items.Clear();

            //label_EntregadoresCount.Text = "Entregadores: " + database.GetEntregadores().Count;

            foreach (var produto in database.GetProdutos())
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = produto.id.ToString();

                
                

                if (tipo == "pizzas") {

                    listItem.SubItems.Add(produto.Nome);

                    listItem.SubItems.Add(produto.preço1.ToString());

                    listItem.SubItems.Add(produto.preço2.ToString());

                    listItem.SubItems.Add(produto.preço3.ToString());

                    listItem.SubItems.Add(produto.tipo);

                    listItem.SubItems.Add(produto.Descrição);


                    if (produto.tipo == "pizzas") 
                    listView1.Items.Add(listItem);
                    listView1.Visible = true;
                    listView1.BringToFront();
                }


                if (tipo == "bebidas")
                {
                    listItem.SubItems.Add(produto.Nome);

                    listItem.SubItems.Add(produto.preço1.ToString());                    

                    listItem.SubItems.Add(produto.tipo);

                    listItem.SubItems.Add(produto.Descrição);

                    if (produto.tipo == "bebidas")
                        listView2.Items.Add(listItem);
                    listView2.Visible = true;
                    listView2.BringToFront();
                }

            }
        }

        private void resetPanels()
        {
            tb_pizzas_id.Clear();
            tb_bebidas_id.Clear();

            tb_pizzas_nome.Clear();
            tb_bebidas_nome.Clear();

            tb_pizzas_descricao.Clear();
            tb_bebidas_descricao.Clear();

            tb_pizzas_preco1.Text = "0000";
            tb_pizzas_preco2.Text = "0000";
            tb_pizzas_preco3.Text = "0000";
            tb_bebidas_preco.Text = "0000";

        }


        private void FormProdutos_Load(object sender, EventArgs e)
        {
            refreshDate("pizzas");
        }



        private void tb_pizzas_Salvar_Click(object sender, EventArgs e)
        {

            if (tb_pizzas_id.Text.Length > 0 && tb_pizzas_nome.Text.Length > 0)
            {

                try
                {


                    decimal preco1 = Convert.ToDecimal(tb_pizzas_preco1.Text);                   
                    decimal preco2 = Convert.ToDecimal(tb_pizzas_preco2.Text);
                    decimal preco3 = Convert.ToDecimal(tb_pizzas_preco3.Text);

                    

                    if (preco1 == 0 || preco2 == 0 || preco3 == 0)
                    {
                        MessageBox.Show("O valor dos produtos não pode ser igual a 0. \n \n Defina os preços dos 3 tamanhos e tente novamente.");
                    } else
                    {

                        if(database.Product_id_Exists(tb_pizzas_id.Text))
                        {
                            MessageBox.Show("Já Existe um produto com esse Código.");
                        } else
                        {

                            produto new_prod = new produto();

                            new_prod.id = Convert.ToInt32(tb_pizzas_id.Text);
                            new_prod.Nome = tb_pizzas_nome.Text;
                            new_prod.Descrição = tb_pizzas_descricao.Text;
                            new_prod.tipo = "pizzas";

                            new_prod.preço1 = preco1;
                            new_prod.preço2 = preco2;
                            new_prod.preço3 = preco3;

                            string result = database.add_Produto(new_prod);

                            MessageBox.Show(result);

                            panel_Pizzas.Visible = false;

                            resetPanels();
                            refreshDate("pizzas");


                        }


                    }
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Informe os Preços corretamente. \n \n" + ex.Message);
                    
                }

            } else
            {
                MessageBox.Show("Informe o Código e o nome do produto");
            }


        }

        private void tb_bebidas_Salvar_Click(object sender, EventArgs e)
        {
            if (tb_bebidas_id.Text.Length > 0 && tb_bebidas_nome.Text.Length > 0)
            {

                try
                {
                    decimal preco = Convert.ToDecimal(tb_bebidas_preco.Text);
                    


                    if (preco == 0 )
                    {
                        MessageBox.Show("O valor do produto não pode ser igual a 0. \n \n Defina os preços e tente novamente.");
                    }
                    else
                    {

                        if (database.Product_id_Exists(tb_bebidas_id.Text))
                        {
                            MessageBox.Show("Já Existe um produto com esse Código.");
                        }
                        else
                        {

                            produto new_prod = new produto();

                            new_prod.id = Convert.ToInt32(tb_bebidas_id.Text);
                            new_prod.Nome = tb_bebidas_nome.Text;
                            new_prod.Descrição = tb_bebidas_descricao.Text;
                            new_prod.tipo = "bebidas";

                            new_prod.preço1 = preco;
                            

                            string result = database.add_Produto(new_prod);

                            MessageBox.Show(result);

                            panel_Bebidas.Visible = false;

                            resetPanels();
                            refreshDate("bebidas");


                        }


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Informe os Preços corretamente. \n \n" + ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Informe o Código e o nome do produto");
            }


        }



        private void bt_panelNew_bebidas_Close_Click(object sender, EventArgs e)
        {
            panel_Bebidas.Visible = false;
            resetPanels();
        }

        private void button_panelNew_Pizzas_Close_Click(object sender, EventArgs e)
        {
            panel_Pizzas.Visible = false;
            resetPanels();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            resetPanels();

            panel_Bebidas.Visible = false;
            panel_Pizzas.Visible = false;

            panel_select_tipo.Visible = true;
            panel_select_tipo.BringToFront();
        }


        private void bt_panelSelectTipo_choicePizza_Click(object sender, EventArgs e)
        {
            panel_select_tipo.Visible = false;
            panel_Bebidas.Visible = false;

            panel_Pizzas.Visible = true;
            tb_pizzas_id.Focus();
            panel_Pizzas.BringToFront();
        }

        private void bt_panelSelectTipo_choiceBebida_Click(object sender, EventArgs e)
        {
            panel_select_tipo.Visible = false;
            panel_Pizzas.Visible = false;

            panel_Bebidas.Visible = true;
            tb_bebidas_id.Focus();
            panel_Bebidas.BringToFront();
        }

        private void bt_panelSelectTipo_close_Click(object sender, EventArgs e)
        {
            resetPanels();
            panel_select_tipo.Visible = false;
        }


        private void tb_pizzas_preco1_Click(object sender, EventArgs e)
        {
            tb_pizzas_preco1.ResetText();
            tb_pizzas_preco1.SelectAll();

        }

        private void tb_pizzas_preco2_Click(object sender, EventArgs e)
        {
            tb_pizzas_preco2.ResetText();
            tb_pizzas_preco2.SelectAll();
        }

        private void tb_pizzas_preco3_Click(object sender, EventArgs e)
        {
            tb_pizzas_preco3.ResetText();
            tb_pizzas_preco3.SelectAll();
        }

        private void tb_bebidas_preco_Click(object sender, EventArgs e)
        {
            tb_bebidas_preco.ResetText();
            tb_bebidas_preco.SelectAll();
        }

        private void radioButton_Pizzas_CheckedChanged(object sender, EventArgs e)
        {
            refreshDate("pizzas");
        }

        private void radioButton_bebidas_CheckedChanged(object sender, EventArgs e)
        {
            refreshDate("bebidas");
        }



        private void btExclui_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView2.SelectedItems.Clear();

                DialogResult result = MessageBox.Show("Deseja realmente excluir o Produto " + listView1.SelectedItems[0].SubItems[1].Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    database.excluir_Produto(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshDate("pizzas");
                }
            }

            if (listView2.SelectedItems.Count > 0)
            {
                listView1.SelectedItems.Clear();
                DialogResult result = MessageBox.Show("Deseja realmente excluir o Produto " + listView2.SelectedItems[0].SubItems[1].Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    database.excluir_Produto(listView2.SelectedItems[0].SubItems[0].Text);
                    refreshDate("bebidas");
                }
            }

        }
    }
}
