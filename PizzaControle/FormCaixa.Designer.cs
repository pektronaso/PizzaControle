namespace PizzaControle
{
    partial class FormCaixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.bt_AbrirCaixa = new System.Windows.Forms.Button();
            this.bt_FecharCaixa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_code = new System.Windows.Forms.Label();
            this.lb_movimentacao = new System.Windows.Forms.Label();
            this.lb_entradas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_despesas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_initialAmmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_AbrirCaixa = new System.Windows.Forms.Panel();
            this.bt_pnAbrirCaixa = new System.Windows.Forms.Button();
            this.numericUpDown_AmmountInCaixa = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_FecharCaixa = new System.Windows.Forms.Panel();
            this.bt_pnFecharCaixa = new System.Windows.Forms.Button();
            this.numericUpDown_FecharAmmount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_AbrirCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AmmountInCaixa)).BeginInit();
            this.pn_FecharCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FecharAmmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "STATUS DE CAIXA: ";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_status.Font = new System.Drawing.Font("Cooper Std Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_status.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Location = new System.Drawing.Point(392, 16);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(161, 33);
            this.lb_status.TabIndex = 2;
            this.lb_status.Text = "FECHADO";
            // 
            // bt_AbrirCaixa
            // 
            this.bt_AbrirCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_AbrirCaixa.Location = new System.Drawing.Point(23, 321);
            this.bt_AbrirCaixa.Name = "bt_AbrirCaixa";
            this.bt_AbrirCaixa.Size = new System.Drawing.Size(314, 51);
            this.bt_AbrirCaixa.TabIndex = 3;
            this.bt_AbrirCaixa.Text = "ABRIR CAIXA";
            this.bt_AbrirCaixa.UseVisualStyleBackColor = true;
            this.bt_AbrirCaixa.Click += new System.EventHandler(this.bt_AbrirCaixa_Click);
            // 
            // bt_FecharCaixa
            // 
            this.bt_FecharCaixa.Enabled = false;
            this.bt_FecharCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_FecharCaixa.Location = new System.Drawing.Point(372, 321);
            this.bt_FecharCaixa.Name = "bt_FecharCaixa";
            this.bt_FecharCaixa.Size = new System.Drawing.Size(314, 51);
            this.bt_FecharCaixa.TabIndex = 4;
            this.bt_FecharCaixa.Text = "FECHAR CAIXA";
            this.bt_FecharCaixa.UseVisualStyleBackColor = true;
            this.bt_FecharCaixa.Click += new System.EventHandler(this.bt_FecharCaixa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(139, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "CAIXA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(321, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Movimentação Atual:";
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_code.Location = new System.Drawing.Point(206, 98);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(37, 21);
            this.lb_code.TabIndex = 7;
            this.lb_code.Text = "000";
            // 
            // lb_movimentacao
            // 
            this.lb_movimentacao.AutoSize = true;
            this.lb_movimentacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_movimentacao.Location = new System.Drawing.Point(501, 138);
            this.lb_movimentacao.Name = "lb_movimentacao";
            this.lb_movimentacao.Size = new System.Drawing.Size(64, 21);
            this.lb_movimentacao.TabIndex = 8;
            this.lb_movimentacao.Text = "R$ 0,00";
            // 
            // lb_entradas
            // 
            this.lb_entradas.AutoSize = true;
            this.lb_entradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_entradas.Location = new System.Drawing.Point(206, 202);
            this.lb_entradas.Name = "lb_entradas";
            this.lb_entradas.Size = new System.Drawing.Size(64, 21);
            this.lb_entradas.TabIndex = 10;
            this.lb_entradas.Text = "R$ 0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(120, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Entradas:";
            // 
            // lb_despesas
            // 
            this.lb_despesas.AutoSize = true;
            this.lb_despesas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_despesas.Location = new System.Drawing.Point(411, 202);
            this.lb_despesas.Name = "lb_despesas";
            this.lb_despesas.Size = new System.Drawing.Size(64, 21);
            this.lb_despesas.TabIndex = 12;
            this.lb_despesas.Text = "R$ 0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(321, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Despesas:";
            // 
            // lb_initialAmmount
            // 
            this.lb_initialAmmount.AutoSize = true;
            this.lb_initialAmmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_initialAmmount.Location = new System.Drawing.Point(206, 138);
            this.lb_initialAmmount.Name = "lb_initialAmmount";
            this.lb_initialAmmount.Size = new System.Drawing.Size(64, 21);
            this.lb_initialAmmount.TabIndex = 14;
            this.lb_initialAmmount.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor em Caixa:";
            // 
            // pn_AbrirCaixa
            // 
            this.pn_AbrirCaixa.Controls.Add(this.bt_pnAbrirCaixa);
            this.pn_AbrirCaixa.Controls.Add(this.numericUpDown_AmmountInCaixa);
            this.pn_AbrirCaixa.Controls.Add(this.label2);
            this.pn_AbrirCaixa.Location = new System.Drawing.Point(173, 123);
            this.pn_AbrirCaixa.Name = "pn_AbrirCaixa";
            this.pn_AbrirCaixa.Size = new System.Drawing.Size(380, 100);
            this.pn_AbrirCaixa.TabIndex = 15;
            this.pn_AbrirCaixa.Visible = false;
            // 
            // bt_pnAbrirCaixa
            // 
            this.bt_pnAbrirCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_pnAbrirCaixa.Location = new System.Drawing.Point(296, 33);
            this.bt_pnAbrirCaixa.Name = "bt_pnAbrirCaixa";
            this.bt_pnAbrirCaixa.Size = new System.Drawing.Size(77, 32);
            this.bt_pnAbrirCaixa.TabIndex = 16;
            this.bt_pnAbrirCaixa.Text = "ABRIR";
            this.bt_pnAbrirCaixa.UseVisualStyleBackColor = true;
            this.bt_pnAbrirCaixa.Click += new System.EventHandler(this.bt_pnAbrirCaixa_Click);
            // 
            // numericUpDown_AmmountInCaixa
            // 
            this.numericUpDown_AmmountInCaixa.DecimalPlaces = 2;
            this.numericUpDown_AmmountInCaixa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_AmmountInCaixa.Location = new System.Drawing.Point(167, 34);
            this.numericUpDown_AmmountInCaixa.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AmmountInCaixa.Name = "numericUpDown_AmmountInCaixa";
            this.numericUpDown_AmmountInCaixa.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_AmmountInCaixa.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor em Caixa:";
            // 
            // pn_FecharCaixa
            // 
            this.pn_FecharCaixa.Controls.Add(this.bt_pnFecharCaixa);
            this.pn_FecharCaixa.Controls.Add(this.numericUpDown_FecharAmmount);
            this.pn_FecharCaixa.Controls.Add(this.label6);
            this.pn_FecharCaixa.Location = new System.Drawing.Point(173, 123);
            this.pn_FecharCaixa.Name = "pn_FecharCaixa";
            this.pn_FecharCaixa.Size = new System.Drawing.Size(380, 100);
            this.pn_FecharCaixa.TabIndex = 16;
            this.pn_FecharCaixa.Visible = false;
            // 
            // bt_pnFecharCaixa
            // 
            this.bt_pnFecharCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_pnFecharCaixa.Location = new System.Drawing.Point(296, 33);
            this.bt_pnFecharCaixa.Name = "bt_pnFecharCaixa";
            this.bt_pnFecharCaixa.Size = new System.Drawing.Size(77, 32);
            this.bt_pnFecharCaixa.TabIndex = 16;
            this.bt_pnFecharCaixa.Text = "FECHAR";
            this.bt_pnFecharCaixa.UseVisualStyleBackColor = true;
            this.bt_pnFecharCaixa.Click += new System.EventHandler(this.bt_pnFecharCaixa_Click);
            // 
            // numericUpDown_FecharAmmount
            // 
            this.numericUpDown_FecharAmmount.DecimalPlaces = 2;
            this.numericUpDown_FecharAmmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_FecharAmmount.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_FecharAmmount.Location = new System.Drawing.Point(167, 34);
            this.numericUpDown_FecharAmmount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_FecharAmmount.Name = "numericUpDown_FecharAmmount";
            this.numericUpDown_FecharAmmount.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_FecharAmmount.TabIndex = 15;
            this.numericUpDown_FecharAmmount.Value = new decimal(new int[] {
            230,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor em Caixa:";
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 405);
            this.Controls.Add(this.pn_FecharCaixa);
            this.Controls.Add(this.lb_initialAmmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_despesas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_entradas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_movimentacao);
            this.Controls.Add(this.lb_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_FecharCaixa);
            this.Controls.Add(this.bt_AbrirCaixa);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_AbrirCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.FormCaixa_Load);
            this.pn_AbrirCaixa.ResumeLayout(false);
            this.pn_AbrirCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AmmountInCaixa)).EndInit();
            this.pn_FecharCaixa.ResumeLayout(false);
            this.pn_FecharCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FecharAmmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lb_status;
        private Button bt_AbrirCaixa;
        private Button bt_FecharCaixa;
        private Label label3;
        private Label label4;
        private Label lb_code;
        private Label lb_movimentacao;
        private Label lb_entradas;
        private Label label8;
        private Label lb_despesas;
        private Label label10;
        private Label lb_initialAmmount;
        private Label label5;
        private Panel pn_AbrirCaixa;
        private NumericUpDown numericUpDown_AmmountInCaixa;
        private Label label2;
        private Button bt_pnAbrirCaixa;
        private Panel pn_FecharCaixa;
        private Button bt_pnFecharCaixa;
        private NumericUpDown numericUpDown_FecharAmmount;
        private Label label6;
    }
}