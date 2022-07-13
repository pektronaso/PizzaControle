namespace PizzaControle
{
    partial class FormClientes
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
            this.cH_id = new System.Windows.Forms.ColumnHeader();
            this.cH_nome = new System.Windows.Forms.ColumnHeader();
            this.cH_endereco = new System.Windows.Forms.ColumnHeader();
            this.ch_numero = new System.Windows.Forms.ColumnHeader();
            this.cH_Referencia = new System.Windows.Forms.ColumnHeader();
            this.cH_Telefone = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExclui = new System.Windows.Forms.PictureBox();
            this.btNovo = new System.Windows.Forms.PictureBox();
            this.btAlterar = new System.Windows.Forms.PictureBox();
            this.tb_search_id = new System.Windows.Forms.TextBox();
            this.tb_search_nome = new System.Windows.Forms.TextBox();
            this.tb_search_endereco = new System.Windows.Forms.TextBox();
            this.tb_search_numero = new System.Windows.Forms.TextBox();
            this.tb_search_telefone = new System.Windows.Forms.TextBox();
            this.tb_search_referencia = new System.Windows.Forms.TextBox();
            this.panelNovo = new System.Windows.Forms.Panel();
            this.button_novo_cancela = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_novoSalvar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_novo_telefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_novo_referencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_novo_numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_novo_endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_novo_nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btExclui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterar)).BeginInit();
            this.panelNovo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_novoSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_id,
            this.cH_nome,
            this.cH_endereco,
            this.ch_numero,
            this.cH_Referencia,
            this.cH_Telefone});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1001, 511);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cH_id
            // 
            this.cH_id.Text = "id";
            // 
            // cH_nome
            // 
            this.cH_nome.Text = "Nome";
            this.cH_nome.Width = 255;
            // 
            // cH_endereco
            // 
            this.cH_endereco.Text = "Endereço";
            this.cH_endereco.Width = 280;
            // 
            // ch_numero
            // 
            this.ch_numero.Text = "Nº";
            this.ch_numero.Width = 70;
            // 
            // cH_Referencia
            // 
            this.cH_Referencia.DisplayIndex = 5;
            this.cH_Referencia.Text = "Referência";
            this.cH_Referencia.Width = 200;
            // 
            // cH_Telefone
            // 
            this.cH_Telefone.DisplayIndex = 4;
            this.cH_Telefone.Text = "Telefone";
            this.cH_Telefone.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(186, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Excluir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Alterar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Novo";
            // 
            // btExclui
            // 
            this.btExclui.Image = global::PizzaControle.Properties.Resources.remove_user;
            this.btExclui.Location = new System.Drawing.Point(186, 555);
            this.btExclui.Name = "btExclui";
            this.btExclui.Size = new System.Drawing.Size(79, 67);
            this.btExclui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExclui.TabIndex = 24;
            this.btExclui.TabStop = false;
            this.btExclui.Click += new System.EventHandler(this.btExclui_Click);
            // 
            // btNovo
            // 
            this.btNovo.Image = global::PizzaControle.Properties.Resources.add_user_vector_icon;
            this.btNovo.Location = new System.Drawing.Point(16, 555);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(79, 67);
            this.btNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btNovo.TabIndex = 23;
            this.btNovo.TabStop = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::PizzaControle.Properties.Resources.edit_user;
            this.btAlterar.Location = new System.Drawing.Point(101, 555);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(79, 67);
            this.btAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btAlterar.TabIndex = 28;
            this.btAlterar.TabStop = false;
            // 
            // tb_search_id
            // 
            this.tb_search_id.Location = new System.Drawing.Point(12, 9);
            this.tb_search_id.Name = "tb_search_id";
            this.tb_search_id.Size = new System.Drawing.Size(57, 23);
            this.tb_search_id.TabIndex = 29;
            // 
            // tb_search_nome
            // 
            this.tb_search_nome.Location = new System.Drawing.Point(75, 9);
            this.tb_search_nome.Name = "tb_search_nome";
            this.tb_search_nome.Size = new System.Drawing.Size(250, 23);
            this.tb_search_nome.TabIndex = 30;
            // 
            // tb_search_endereco
            // 
            this.tb_search_endereco.Location = new System.Drawing.Point(331, 9);
            this.tb_search_endereco.Name = "tb_search_endereco";
            this.tb_search_endereco.Size = new System.Drawing.Size(277, 23);
            this.tb_search_endereco.TabIndex = 31;
            // 
            // tb_search_numero
            // 
            this.tb_search_numero.Location = new System.Drawing.Point(614, 9);
            this.tb_search_numero.Name = "tb_search_numero";
            this.tb_search_numero.Size = new System.Drawing.Size(57, 23);
            this.tb_search_numero.TabIndex = 32;
            // 
            // tb_search_telefone
            // 
            this.tb_search_telefone.Location = new System.Drawing.Point(677, 9);
            this.tb_search_telefone.Name = "tb_search_telefone";
            this.tb_search_telefone.Size = new System.Drawing.Size(116, 23);
            this.tb_search_telefone.TabIndex = 33;
            // 
            // tb_search_referencia
            // 
            this.tb_search_referencia.Location = new System.Drawing.Point(799, 9);
            this.tb_search_referencia.Name = "tb_search_referencia";
            this.tb_search_referencia.Size = new System.Drawing.Size(214, 23);
            this.tb_search_referencia.TabIndex = 34;
            // 
            // panelNovo
            // 
            this.panelNovo.Controls.Add(this.button_novo_cancela);
            this.panelNovo.Controls.Add(this.label9);
            this.panelNovo.Controls.Add(this.bt_novoSalvar);
            this.panelNovo.Controls.Add(this.label8);
            this.panelNovo.Controls.Add(this.tb_novo_telefone);
            this.panelNovo.Controls.Add(this.label7);
            this.panelNovo.Controls.Add(this.tb_novo_referencia);
            this.panelNovo.Controls.Add(this.label6);
            this.panelNovo.Controls.Add(this.tb_novo_numero);
            this.panelNovo.Controls.Add(this.label5);
            this.panelNovo.Controls.Add(this.tb_novo_endereco);
            this.panelNovo.Controls.Add(this.label4);
            this.panelNovo.Controls.Add(this.tb_novo_nome);
            this.panelNovo.Location = new System.Drawing.Point(117, 164);
            this.panelNovo.Name = "panelNovo";
            this.panelNovo.Size = new System.Drawing.Size(700, 215);
            this.panelNovo.TabIndex = 35;
            this.panelNovo.Visible = false;
            // 
            // button_novo_cancela
            // 
            this.button_novo_cancela.Location = new System.Drawing.Point(676, 3);
            this.button_novo_cancela.Name = "button_novo_cancela";
            this.button_novo_cancela.Size = new System.Drawing.Size(21, 22);
            this.button_novo_cancela.TabIndex = 28;
            this.button_novo_cancela.Text = "X";
            this.button_novo_cancela.UseVisualStyleBackColor = true;
            this.button_novo_cancela.Click += new System.EventHandler(this.button_novo_cancela_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(614, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Salvar";
            // 
            // bt_novoSalvar
            // 
            this.bt_novoSalvar.Image = global::PizzaControle.Properties.Resources.add_user_vector_icon;
            this.bt_novoSalvar.Location = new System.Drawing.Point(614, 143);
            this.bt_novoSalvar.Name = "bt_novoSalvar";
            this.bt_novoSalvar.Size = new System.Drawing.Size(79, 67);
            this.bt_novoSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_novoSalvar.TabIndex = 26;
            this.bt_novoSalvar.TabStop = false;
            this.bt_novoSalvar.Click += new System.EventHandler(this.bt_novoSalvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(73, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefone:";
            // 
            // tb_novo_telefone
            // 
            this.tb_novo_telefone.Location = new System.Drawing.Point(137, 106);
            this.tb_novo_telefone.Name = "tb_novo_telefone";
            this.tb_novo_telefone.Size = new System.Drawing.Size(178, 23);
            this.tb_novo_telefone.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(2, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ponto de Referência:";
            // 
            // tb_novo_referencia
            // 
            this.tb_novo_referencia.Location = new System.Drawing.Point(138, 77);
            this.tb_novo_referencia.Name = "tb_novo_referencia";
            this.tb_novo_referencia.Size = new System.Drawing.Size(464, 23);
            this.tb_novo_referencia.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(566, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nº:";
            // 
            // tb_novo_numero
            // 
            this.tb_novo_numero.Location = new System.Drawing.Point(596, 49);
            this.tb_novo_numero.Name = "tb_novo_numero";
            this.tb_novo_numero.Size = new System.Drawing.Size(73, 23);
            this.tb_novo_numero.TabIndex = 4;
            this.tb_novo_numero.TextChanged += new System.EventHandler(this.tb_novo_numero_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Endereço:";
            // 
            // tb_novo_endereco
            // 
            this.tb_novo_endereco.Location = new System.Drawing.Point(137, 48);
            this.tb_novo_endereco.Name = "tb_novo_endereco";
            this.tb_novo_endereco.Size = new System.Drawing.Size(425, 23);
            this.tb_novo_endereco.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(82, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome:";
            // 
            // tb_novo_nome
            // 
            this.tb_novo_nome.Location = new System.Drawing.Point(137, 18);
            this.tb_novo_nome.Name = "tb_novo_nome";
            this.tb_novo_nome.Size = new System.Drawing.Size(532, 23);
            this.tb_novo_nome.TabIndex = 0;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 630);
            this.Controls.Add(this.panelNovo);
            this.Controls.Add(this.tb_search_referencia);
            this.Controls.Add(this.tb_search_telefone);
            this.Controls.Add(this.tb_search_numero);
            this.Controls.Add(this.tb_search_endereco);
            this.Controls.Add(this.tb_search_nome);
            this.Controls.Add(this.tb_search_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExclui);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btExclui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAlterar)).EndInit();
            this.panelNovo.ResumeLayout(false);
            this.panelNovo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_novoSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader cH_id;
        private ColumnHeader cH_nome;
        private ColumnHeader cH_endereco;
        private ColumnHeader ch_numero;
        private ColumnHeader cH_Referencia;
        private ColumnHeader cH_Telefone;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox btExclui;
        private PictureBox btNovo;
        private PictureBox btAlterar;
        private TextBox tb_search_id;
        private TextBox tb_search_nome;
        private TextBox tb_search_endereco;
        private TextBox tb_search_numero;
        private TextBox tb_search_telefone;
        private TextBox tb_search_referencia;
        private Panel panelNovo;
        private Label label4;
        private TextBox tb_novo_nome;
        private Label label6;
        private TextBox tb_novo_numero;
        private Label label5;
        private TextBox tb_novo_endereco;
        private Label label8;
        private TextBox tb_novo_telefone;
        private Label label7;
        private TextBox tb_novo_referencia;
        private Label label9;
        private PictureBox bt_novoSalvar;
        private Button button_novo_cancela;
    }
}