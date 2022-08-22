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
    public partial class FormEntradaEntregador : Form
    {
        public FormEntradaEntregador()
        {
            InitializeComponent();
        }

        private void refreshDate()
        {
            listView1.Items.Clear();

            

            foreach (var entregador in Database.Get_EntregadoresDisponible())
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = entregador.id.ToString();

                listItem.SubItems.Add(entregador.nome);


                listView1.Items.Add(listItem);
            }
        }


        private void FormEntradaEntregador_Load(object sender, EventArgs e)
        {
            refreshDate();
        }
    }
}
