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
            this.label2 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Cooper Std Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(108, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "FECHADO";
            // 
            // bt_AbrirCaixa
            // 
            this.bt_AbrirCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_AbrirCaixa.Location = new System.Drawing.Point(12, 312);
            this.bt_AbrirCaixa.Name = "bt_AbrirCaixa";
            this.bt_AbrirCaixa.Size = new System.Drawing.Size(376, 51);
            this.bt_AbrirCaixa.TabIndex = 3;
            this.bt_AbrirCaixa.Text = "ABRIR CAIXA";
            this.bt_AbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // bt_FecharCaixa
            // 
            this.bt_FecharCaixa.Enabled = false;
            this.bt_FecharCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_FecharCaixa.Location = new System.Drawing.Point(12, 378);
            this.bt_FecharCaixa.Name = "bt_FecharCaixa";
            this.bt_FecharCaixa.Size = new System.Drawing.Size(376, 51);
            this.bt_FecharCaixa.TabIndex = 4;
            this.bt_FecharCaixa.Text = "FECHAR CAIXA";
            this.bt_FecharCaixa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(139, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "CAIXA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Movimentação Atual:";
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_code.Location = new System.Drawing.Point(206, 122);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(57, 21);
            this.lb_code.TabIndex = 7;
            this.lb_code.Text = "000XX";
            // 
            // lb_movimentacao
            // 
            this.lb_movimentacao.AutoSize = true;
            this.lb_movimentacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_movimentacao.Location = new System.Drawing.Point(206, 159);
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
            this.lb_despesas.Location = new System.Drawing.Point(206, 236);
            this.lb_despesas.Name = "lb_despesas";
            this.lb_despesas.Size = new System.Drawing.Size(64, 21);
            this.lb_despesas.TabIndex = 12;
            this.lb_despesas.Text = "R$ 0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(116, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Despesas:";
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.FormCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
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
    }
}