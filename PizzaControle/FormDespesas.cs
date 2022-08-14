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

            

            foreach (var funcionario in Database.GetFuncionarios())
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = funcionario.id.ToString();

                listItem.SubItems.Add(funcionario.nome);

                listItem.SubItems.Add(funcionario.nivel.ToString());



                listView1.Items.Add(listItem);
            }
        }

        private void FormDespesas_Load(object sender, EventArgs e)
        {

        }
    }
}
