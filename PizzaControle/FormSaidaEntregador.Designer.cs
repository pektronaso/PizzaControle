namespace PizzaControle
{
    partial class FormSaidaEntregador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_id = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_entregador = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_serviceID = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_id,
            this.columnHeader_entregador,
            this.columnHeader_serviceID});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 347);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader_id
            // 
            this.columnHeader_id.Text = "id";
            this.columnHeader_id.Width = 0;
            // 
            // columnHeader_entregador
            // 
            this.columnHeader_entregador.Text = "Entregador";
            this.columnHeader_entregador.Width = 323;
            // 
            // columnHeader_serviceID
            // 
            this.columnHeader_serviceID.Text = "serviceID";
            this.columnHeader_serviceID.Width = 0;
            // 
            // FormSaidaEntregador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 373);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormSaidaEntregador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut Entregador";
            this.Load += new System.EventHandler(this.FormSaidaEntregador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader_id;
        private ColumnHeader columnHeader_entregador;
        private ColumnHeader columnHeader_serviceID;
    }
}