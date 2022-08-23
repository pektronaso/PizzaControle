﻿using PizzaControle.Models;
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

        private void refreshData()
        {
            listView1.Items.Clear();

            

            foreach (var entregadorDisponible in entregadorService.Get_EntregadoresDisponible())
            {

                ListViewItem listItem = new ListViewItem();

                listItem.Text = entregadorDisponible.id.ToString();

                listItem.SubItems.Add(entregadorDisponible.nome);


                listView1.Items.Add(listItem);
            }
        }


        private void FormEntradaEntregador_Load(object sender, EventArgs e)
        {
            refreshData();
        }






        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string result = entregadorService.entregadorCheckIn( listView1.SelectedItems[0].Text );

                MessageBox.Show(result);

                refreshData();

                Close();
            }
        }
    }
}
