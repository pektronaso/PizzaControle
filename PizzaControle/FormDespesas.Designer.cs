namespace PizzaControle
{
    partial class FormDespesas
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
            this.columnHeader_comment = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_valor = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExclui = new System.Windows.Forms.PictureBox();
            this.btNovo = new System.Windows.Forms.PictureBox();
            this.lb_totalValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_Caixa = new System.Windows.Forms.Label();
            this.pn_newDespesa = new System.Windows.Forms.Panel();
            this.bt_pnNewDespesa_confirma = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pnNewDespesa_comment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_pnNewDespesa_ammount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.btExclui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNovo)).BeginInit();
            this.pn_newDespesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pnNewDespesa_ammount)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_id,
            this.columnHeader_comment,
            this.columnHeader_valor});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(699, 361);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_id
            // 
            this.columnHeader_id.Text = "id";
            // 
            // columnHeader_comment
            // 
            this.columnHeader_comment.Text = "Comment";
            this.columnHeader_comment.Width = 512;
            // 
            // columnHeader_valor
            // 
            this.columnHeader_valor.Text = "Valor";
            this.columnHeader_valor.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Excluir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Novo";
            // 
            // btExclui
            // 
            this.btExclui.Image = global::PizzaControle.Properties.Resources.remove_user;
            this.btExclui.Location = new System.Drawing.Point(100, 379);
            this.btExclui.Name = "btExclui";
            this.btExclui.Size = new System.Drawing.Size(79, 67);
            this.btExclui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExclui.TabIndex = 30;
            this.btExclui.TabStop = false;
            this.btExclui.Click += new System.EventHandler(this.btExclui_Click);
            // 
            // btNovo
            // 
            this.btNovo.Image = global::PizzaControle.Properties.Resources.add_user_vector_icon;
            this.btNovo.Location = new System.Drawing.Point(13, 379);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(79, 67);
            this.btNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btNovo.TabIndex = 29;
            this.btNovo.TabStop = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // lb_totalValue
            // 
            this.lb_totalValue.AutoSize = true;
            this.lb_totalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_totalValue.ForeColor = System.Drawing.Color.Red;
            this.lb_totalValue.Location = new System.Drawing.Point(604, 383);
            this.lb_totalValue.Name = "lb_totalValue";
            this.lb_totalValue.Size = new System.Drawing.Size(64, 21);
            this.lb_totalValue.TabIndex = 36;
            this.lb_totalValue.Text = "R$ 0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(482, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Total Despesas:";
            // 
            // lb_Caixa
            // 
            this.lb_Caixa.AutoSize = true;
            this.lb_Caixa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Caixa.ForeColor = System.Drawing.Color.Red;
            this.lb_Caixa.Location = new System.Drawing.Point(314, 382);
            this.lb_Caixa.Name = "lb_Caixa";
            this.lb_Caixa.Size = new System.Drawing.Size(87, 21);
            this.lb_Caixa.TabIndex = 37;
            this.lb_Caixa.Text = "Caixa: 000";
            // 
            // pn_newDespesa
            // 
            this.pn_newDespesa.Controls.Add(this.bt_pnNewDespesa_confirma);
            this.pn_newDespesa.Controls.Add(this.label6);
            this.pn_newDespesa.Controls.Add(this.tb_pnNewDespesa_comment);
            this.pn_newDespesa.Controls.Add(this.label4);
            this.pn_newDespesa.Controls.Add(this.nud_pnNewDespesa_ammount);
            this.pn_newDespesa.Location = new System.Drawing.Point(163, 141);
            this.pn_newDespesa.Name = "pn_newDespesa";
            this.pn_newDespesa.Size = new System.Drawing.Size(376, 130);
            this.pn_newDespesa.TabIndex = 38;
            this.pn_newDespesa.Visible = false;
            // 
            // bt_pnNewDespesa_confirma
            // 
            this.bt_pnNewDespesa_confirma.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_pnNewDespesa_confirma.Location = new System.Drawing.Point(211, 94);
            this.bt_pnNewDespesa_confirma.Name = "bt_pnNewDespesa_confirma";
            this.bt_pnNewDespesa_confirma.Size = new System.Drawing.Size(75, 26);
            this.bt_pnNewDespesa_confirma.TabIndex = 4;
            this.bt_pnNewDespesa_confirma.Text = "confirmar";
            this.bt_pnNewDespesa_confirma.UseVisualStyleBackColor = true;
            this.bt_pnNewDespesa_confirma.Click += new System.EventHandler(this.bt_pnNewDespesa_confirma_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(27, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Comentário:";
            // 
            // tb_pnNewDespesa_comment
            // 
            this.tb_pnNewDespesa_comment.Location = new System.Drawing.Point(118, 48);
            this.tb_pnNewDespesa_comment.Multiline = true;
            this.tb_pnNewDespesa_comment.Name = "tb_pnNewDespesa_comment";
            this.tb_pnNewDespesa_comment.Size = new System.Drawing.Size(168, 40);
            this.tb_pnNewDespesa_comment.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor:";
            // 
            // nud_pnNewDespesa_ammount
            // 
            this.nud_pnNewDespesa_ammount.DecimalPlaces = 2;
            this.nud_pnNewDespesa_ammount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_pnNewDespesa_ammount.Location = new System.Drawing.Point(118, 17);
            this.nud_pnNewDespesa_ammount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nud_pnNewDespesa_ammount.Name = "nud_pnNewDespesa_ammount";
            this.nud_pnNewDespesa_ammount.Size = new System.Drawing.Size(120, 25);
            this.nud_pnNewDespesa_ammount.TabIndex = 0;
            // 
            // FormDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.pn_newDespesa);
            this.Controls.Add(this.lb_Caixa);
            this.Controls.Add(this.lb_totalValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExclui);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.FormDespesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btExclui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNovo)).EndInit();
            this.pn_newDespesa.ResumeLayout(false);
            this.pn_newDespesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pnNewDespesa_ammount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader_id;
        private ColumnHeader columnHeader_comment;
        private ColumnHeader columnHeader_valor;
        private Label label3;
        private Label label1;
        private PictureBox btExclui;
        private PictureBox btNovo;
        private Label lb_totalValue;
        private Label label11;
        private Label lb_Caixa;
        private Panel pn_newDespesa;
        private Label label6;
        private TextBox tb_pnNewDespesa_comment;
        private Label label4;
        private NumericUpDown nud_pnNewDespesa_ammount;
        private Button bt_pnNewDespesa_confirma;
    }
}