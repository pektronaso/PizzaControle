namespace PizzaControle
{
    partial class FormFuncionarios
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
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNome = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderType = new System.Windows.Forms.ColumnHeader();
            this.btNovo = new System.Windows.Forms.PictureBox();
            this.btExclui = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_FuncionariosCount = new System.Windows.Forms.Label();
            this.panelNewFuncionario = new System.Windows.Forms.Panel();
            this.buttonFuncionarioCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.panelAlterar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome_altera = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExclui)).BeginInit();
            this.panelNewFuncionario.SuspendLayout();
            this.panelAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterar)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNome,
            this.columnHeaderType});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(685, 479);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "id";
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 360;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Tipo de Conta";
            this.columnHeaderType.Width = 255;
            // 
            // btNovo
            // 
            this.btNovo.Image = global::PizzaControle.Properties.Resources.add_user_vector_icon;
            this.btNovo.Location = new System.Drawing.Point(12, 508);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(79, 67);
            this.btNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btNovo.TabIndex = 1;
            this.btNovo.TabStop = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btExclui
            // 
            this.btExclui.Image = global::PizzaControle.Properties.Resources.remove_user;
            this.btExclui.Location = new System.Drawing.Point(182, 508);
            this.btExclui.Name = "btExclui";
            this.btExclui.Size = new System.Drawing.Size(79, 67);
            this.btExclui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExclui.TabIndex = 2;
            this.btExclui.TabStop = false;
            this.btExclui.Click += new System.EventHandler(this.btExclui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Novo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alterar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(182, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Excluir";
            // 
            // label_FuncionariosCount
            // 
            this.label_FuncionariosCount.AutoSize = true;
            this.label_FuncionariosCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_FuncionariosCount.Location = new System.Drawing.Point(582, 494);
            this.label_FuncionariosCount.Name = "label_FuncionariosCount";
            this.label_FuncionariosCount.Size = new System.Drawing.Size(115, 21);
            this.label_FuncionariosCount.TabIndex = 9;
            this.label_FuncionariosCount.Text = "Funcionários: 0";
            // 
            // panelNewFuncionario
            // 
            this.panelNewFuncionario.Controls.Add(this.buttonFuncionarioCancelar);
            this.panelNewFuncionario.Controls.Add(this.buttonSalvar);
            this.panelNewFuncionario.Controls.Add(this.label4);
            this.panelNewFuncionario.Controls.Add(this.textBoxNome);
            this.panelNewFuncionario.Location = new System.Drawing.Point(54, 178);
            this.panelNewFuncionario.Name = "panelNewFuncionario";
            this.panelNewFuncionario.Size = new System.Drawing.Size(580, 108);
            this.panelNewFuncionario.TabIndex = 10;
            this.panelNewFuncionario.Visible = false;
            // 
            // buttonFuncionarioCancelar
            // 
            this.buttonFuncionarioCancelar.Location = new System.Drawing.Point(402, 54);
            this.buttonFuncionarioCancelar.Name = "buttonFuncionarioCancelar";
            this.buttonFuncionarioCancelar.Size = new System.Drawing.Size(150, 30);
            this.buttonFuncionarioCancelar.TabIndex = 3;
            this.buttonFuncionarioCancelar.Text = "Cancelar";
            this.buttonFuncionarioCancelar.UseVisualStyleBackColor = true;
            this.buttonFuncionarioCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
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
            // panelAlterar
            // 
            this.panelAlterar.Controls.Add(this.button1);
            this.panelAlterar.Controls.Add(this.buttonAlterar);
            this.panelAlterar.Controls.Add(this.label5);
            this.panelAlterar.Controls.Add(this.textBoxNome_altera);
            this.panelAlterar.Location = new System.Drawing.Point(54, 177);
            this.panelAlterar.Name = "panelAlterar";
            this.panelAlterar.Size = new System.Drawing.Size(580, 108);
            this.panelAlterar.TabIndex = 11;
            this.panelAlterar.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // textBoxNome_altera
            // 
            this.textBoxNome_altera.Location = new System.Drawing.Point(64, 25);
            this.textBoxNome_altera.Name = "textBoxNome_altera";
            this.textBoxNome_altera.Size = new System.Drawing.Size(488, 23);
            this.textBoxNome_altera.TabIndex = 0;
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::PizzaControle.Properties.Resources.edit_user;
            this.btAlterar.Location = new System.Drawing.Point(97, 508);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(79, 67);
            this.btAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btAlterar.TabIndex = 12;
            this.btAlterar.TabStop = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 594);
            this.Controls.Add(this.panelAlterar);
            this.Controls.Add(this.panelNewFuncionario);
            this.Controls.Add(this.label_FuncionariosCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExclui);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.Leave += new System.EventHandler(this.FormFuncionarios_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.btNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExclui)).EndInit();
            this.panelNewFuncionario.ResumeLayout(false);
            this.panelNewFuncionario.PerformLayout();
            this.panelAlterar.ResumeLayout(false);
            this.panelAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private PictureBox btNovo;
        private PictureBox btExclui;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderNome;
        private ColumnHeader columnHeaderType;
        private Label label_FuncionariosCount;
        private Panel panelNewFuncionario;
        private Button buttonSalvar;
        private Label label4;
        private TextBox textBoxNome;
        private Button buttonFuncionarioCancelar;
        private Panel panelAlterar;
        private Button button1;
        private Button buttonAlterar;
        private Label label5;
        private TextBox textBoxNome_altera;
        private PictureBox btAlterar;
    }
}