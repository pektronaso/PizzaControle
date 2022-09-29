namespace PizzaControle
{
    partial class FormNewPedido
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
            this.pnBalcao = new System.Windows.Forms.Panel();
            this.picBalcao = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnIfood = new System.Windows.Forms.Panel();
            this.picIfood = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnBalcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBalcao)).BeginInit();
            this.pnIfood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIfood)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBalcao
            // 
            this.pnBalcao.BackColor = System.Drawing.SystemColors.Control;
            this.pnBalcao.Controls.Add(this.picBalcao);
            this.pnBalcao.Controls.Add(this.label4);
            this.pnBalcao.Controls.Add(this.label1);
            this.pnBalcao.Location = new System.Drawing.Point(12, 37);
            this.pnBalcao.Name = "pnBalcao";
            this.pnBalcao.Size = new System.Drawing.Size(237, 248);
            this.pnBalcao.TabIndex = 0;
            // 
            // picBalcao
            // 
            this.picBalcao.Image = global::PizzaControle.Properties.Resources.balcao;
            this.picBalcao.Location = new System.Drawing.Point(38, 55);
            this.picBalcao.Name = "picBalcao";
            this.picBalcao.Size = new System.Drawing.Size(160, 138);
            this.picBalcao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBalcao.TabIndex = 3;
            this.picBalcao.TabStop = false;
            this.picBalcao.Click += new System.EventHandler(this.picBalcao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(104, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "F1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BALCÃO";
            // 
            // pnIfood
            // 
            this.pnIfood.Controls.Add(this.picIfood);
            this.pnIfood.Controls.Add(this.label5);
            this.pnIfood.Controls.Add(this.label2);
            this.pnIfood.Location = new System.Drawing.Point(276, 37);
            this.pnIfood.Name = "pnIfood";
            this.pnIfood.Size = new System.Drawing.Size(237, 248);
            this.pnIfood.TabIndex = 1;
            // 
            // picIfood
            // 
            this.picIfood.Image = global::PizzaControle.Properties.Resources.ifood;
            this.picIfood.Location = new System.Drawing.Point(38, 55);
            this.picIfood.Name = "picIfood";
            this.picIfood.Size = new System.Drawing.Size(160, 138);
            this.picIfood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIfood.TabIndex = 4;
            this.picIfood.TabStop = false;
            this.picIfood.Click += new System.EventHandler(this.picIfood_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(103, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "F2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IFOOD";
            // 
            // FormNewPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 320);
            this.Controls.Add(this.pnIfood);
            this.Controls.Add(this.pnBalcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNewPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Pedido";
            this.Load += new System.EventHandler(this.FormNewPedido_Load);
            this.pnBalcao.ResumeLayout(false);
            this.pnBalcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBalcao)).EndInit();
            this.pnIfood.ResumeLayout(false);
            this.pnIfood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIfood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnBalcao;
        private Panel pnIfood;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox picBalcao;
        private PictureBox picIfood;
    }
}