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
    public partial class FormSaidaEntregador : Form
    {
        public FormSaidaEntregador()
        {
            InitializeComponent();
        }

        private void refreshData()
        {
            listView1.Items.Clear();



            foreach (var entregadorInDisponible in entregadorService.Get_EntregadoresIndisponible())
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = entregadorInDisponible.id.ToString();

                listItem.SubItems.Add(entregadorInDisponible.nome);

                listItem.SubItems.Add(entregadorInDisponible.inServiceID.ToString());


                listView1.Items.Add(listItem);
            }
        }


        private void FormSaidaEntregador_Load(object sender, EventArgs e)
        {
            refreshData();
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string result = entregadorService.entregadorCheckOut(listView1.SelectedItems[0].SubItems[2].Text);

                MessageBox.Show(result);

                refreshData();

                Close();
            }
        }
    }
}
