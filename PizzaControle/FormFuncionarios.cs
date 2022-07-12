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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        
        private void refreshDate()
        {
            listView1.Items.Clear();

            label_FuncionariosCount.Text = "Funcionários: " + database.GetFuncionarios().Count;

            foreach (var funcionario in database.GetFuncionarios())
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = funcionario.id.ToString();

                listItem.SubItems.Add(funcionario.nome);

                listItem.SubItems.Add(funcionario.nivel.ToString());



                listView1.Items.Add(listItem);
            }
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            refreshDate();            
        }


        private void FormFuncionarios_Leave(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0) { 
            
            
                
                
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            panelNewFuncionario.Visible = true;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length > 1)
            {
                MessageBox.Show(database.add_Funcionario(textBoxNome.Text));

                textBoxNome.Clear();
                panelNewFuncionario.Visible = false;

                refreshDate();
                
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            panelNewFuncionario.Visible = false;
        }

        private void btExclui_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {

                if (listView1.SelectedItems[0].SubItems[2].Text == "1")
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir o funcionário " + listView1.SelectedItems[0].SubItems[1].Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        database.excluir_Funcionario(listView1.SelectedItems[0].SubItems[0].Text);
                        refreshDate();
                    }
                    else if (result == DialogResult.No)
                    {
                        //...
                    }
                } else
                {
                    MessageBox.Show("Não é possivel excluir um administrador");
                }

            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            if(textBoxNome_altera.Text.Length > 2)
            {
                database.alterar_Funcionario(listView1.SelectedItems[0].SubItems[0].Text, textBoxNome_altera.Text);

                textBoxNome_altera.Clear();
                panelAlterar.Visible = false;
                refreshDate();
            }


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            panelAlterar.Visible = false;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {

                if (listView1.SelectedItems[0].SubItems[2].Text == "1")
                {
                    panelAlterar.Visible = true;
                    textBoxNome_altera.Text = listView1.SelectedItems[0].SubItems[1].Text;
                }

                
            }
            
        }
    }
}
