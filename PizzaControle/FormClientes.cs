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
    }
}
