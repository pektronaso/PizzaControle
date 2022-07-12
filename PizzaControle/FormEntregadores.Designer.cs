namespace PizzaControle
{
    partial class FormEntregadores
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
            this.panelNewEntregador = new System.Windows.Forms.Panel();
            this.buttonNewEntregadorCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonAlteraCancel = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAlterar = new System.Windows.Forms.Panel();
            this.textBoxNome_altera = new System.Windows.Forms.TextBox();
            this.label_EntregadoresCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExclui = new System.Windows.Forms.PictureBox();
            this.btNovo = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNome = new System.Windows.Forms.ColumnHeader();
            this.btAlterar = new System.Windows.Forms.PictureBox();
            this.panelNewEntregador.SuspendLayout();
            this.panelAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExclui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNewEntregador
            // 
            this.panelNewEntregador.Controls.Add(this.buttonNewEntregadorCancelar);
            this.panelNewEntregador.Controls.Add(this.buttonSalvar);
            this.panelNewEntregador.Controls.Add(this.label4);
            this.panelNewEntregador.Controls.Add(this.textBoxNome);
            this.panelNewEntregador.Location = new System.Drawing.Point(50, 151);
            this.panelNewEntregador.Name = "panelNewEntregador";
            this.panelNewEntregador.Size = new System.Drawing.Size(580, 108);
            this.panelNewEntregador.TabIndex = 20;
            this.panelNewEntregador.Visible = false;
            // 
            // buttonNewEntregadorCancelar
            // 
            this.buttonNewEntregadorCancelar.Location = new System.Drawing.Point(402, 54);
            this.buttonNewEntregadorCancelar.Name = "buttonNewEntregadorCancelar";
            this.buttonNewEntregadorCancelar.Size = new System.Drawing.Size(150, 30);
            this.buttonNewEntregadorCancelar.TabIndex = 3;
            this.buttonNewEntregadorCancelar.Text = "Cancelar";
            this.buttonNewEntregadorCancelar.UseVisualStyleBackColor = true;
            this.buttonNewEntregadorCancelar.Click += new System.EventHandler(this.buttonNewEntregadorCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(219, 54);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(177, 30);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(64, 25);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(488, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // buttonAlteraCancel
            // 
            this.buttonAlteraCancel.Location = new System.Drawing.Point(402, 54);
            this.buttonAlteraCancel.Name = "buttonAlteraCancel";
            this.buttonAlteraCancel.Size = new System.Drawing.Size(150, 30);
            this.buttonAlteraCancel.TabIndex = 3;
            this.buttonAlteraCancel.Text = "Cancelar";
            this.buttonAlteraCancel.UseVisualStyleBackColor = true;
            this.buttonAlteraCancel.Click += new System.EventHandler(this.buttonAlteraCancel_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(219, 54);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(177, 30);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Salvar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome:";
            // 
            // panelAlterar
            // 
            this.panelAlterar.Controls.Add(this.buttonAlteraCancel);
            this.panelAlterar.Controls.Add(this.buttonAlterar);
            this.panelAlterar.Controls.Add(this.label5);
            this.panelAlterar.Controls.Add(this.textBoxNome_altera);
            this.panelAlterar.Location = new System.Drawing.Point(49, 152);
            this.panelAlterar.Name = "panelAlterar";
            this.panelAlterar.Size = new System.Drawing.Size(580, 108);
            this.panelAlterar.TabIndex = 21;
            this.panelAlterar.Visible = false;
            // 
            // textBoxNome_altera
            // 
            this.textBoxNome_altera.Location = new System.Drawing.Point(64, 25);
            this.textBoxNome_altera.Name = "textBoxNome_altera";
            this.textBoxNome_altera.Size = new System.Drawing.Size(488, 23);
            this.textBoxNome_altera.TabIndex = 0;
            // 
            // label_EntregadoresCount
            // 
            this.label_EntregadoresCount.AutoSize = true;
            this.label_EntregadoresCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EntregadoresCount.Location = new System.Drawing.Point(577, 486);
            this.label_EntregadoresCount.Name = "label_EntregadoresCount";
            this.label_EntregadoresCount.Size = new System.Drawing.Size(118, 21);
            this.label_EntregadoresCount.TabIndex = 19;
            this.label_EntregadoresCount.Text = "Entregadores: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(177, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Excluir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Alterar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Novo";
            // 
            // btExclui
            // 
            this.btExclui.Image = global::PizzaControle.Properties.Resources.remove_user;
            this.btExclui.Location = new System.Drawing.Point(177, 500);
            this.btExclui.Name = "btExclui";
            this.btExclui.Size = new System.Drawing.Size(79, 67);
            this.btExclui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExclui.TabIndex = 15;
            this.btExclui.TabStop = false;
            this.btExclui.Click += new System.EventHandler(this.btExclui_Click);
            // 
            // btNovo
            // 
            this.btNovo.Image = global::PizzaControle.Properties.Resources.add_user_vector_icon;
            this.btNovo.Location = new System.Drawing.Point(7, 500);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(79, 67);
            this.btNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btNovo.TabIndex = 14;
            this.btNovo.TabStop = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNome});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(7, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(685, 479);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "id";
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 600;
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::PizzaControle.Properties.Resources.edit_user;
            this.btAlterar.Location = new System.Drawing.Point(92, 500);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(79, 67);
            this.btAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btAlterar.TabIndex = 22;
            this.btAlterar.TabStop = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // FormEntregadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 583);
            this.Controls.Add(this.panelNewEntregador);
            this.Controls.Add(this.panelAlterar);
            this.Controls.Add(this.label_EntregadoresCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExclui);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEntregadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregadores";
            this.Load += new System.EventHandler(this.FormEntregadores_Load);
            this.panelNewEntregador.ResumeLayout(false);
            this.panelNewEntregador.PerformLayout();
            this.panelAlterar.ResumeLayout(false);
            this.panelAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExclui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelNewEntregador;
        private Button buttonNewEntregadorCancelar;
        private Button buttonSalvar;
        private Label label4;
        private TextBox textBoxNome;
        private Button buttonAlteraCancel;
        private Button buttonAlterar;
        private Label label5;
        private Panel panelAlterar;
        private TextBox textBoxNome_altera;
        private Label label_EntregadoresCount;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox btExclui;
        private PictureBox btNovo;
        private ListView listView1;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderNome;
        private PictureBox btAlterar;
    }
}