namespace projetoFarmacia
{
    partial class cadastrar
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
            this.CODIGO = new System.Windows.Forms.Label();
            this.NOME = new System.Windows.Forms.Label();
            this.RG = new System.Windows.Forms.Label();
            this.TELEFONE = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CadastrarBotao = new System.Windows.Forms.Button();
            this.VoltarBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Pessoa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSize = true;
            this.CODIGO.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
            this.CODIGO.Location = new System.Drawing.Point(12, 92);
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Size = new System.Drawing.Size(80, 19);
            this.CODIGO.TabIndex = 1;
            this.CODIGO.Text = "CODIGO";
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
            this.NOME.Location = new System.Drawing.Point(12, 125);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(64, 19);
            this.NOME.TabIndex = 2;
            this.NOME.Text = "NOME";
            // 
            // RG
            // 
            this.RG.AutoSize = true;
            this.RG.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
            this.RG.Location = new System.Drawing.Point(12, 158);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(35, 19);
            this.RG.TabIndex = 3;
            this.RG.Text = "RG";
            this.RG.Click += new System.EventHandler(this.label4_Click);
            // 
            // TELEFONE
            // 
            this.TELEFONE.AutoSize = true;
            this.TELEFONE.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
            this.TELEFONE.Location = new System.Drawing.Point(10, 193);
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.Size = new System.Drawing.Size(108, 19);
            this.TELEFONE.TabIndex = 4;
            this.TELEFONE.Text = "TELEFONE";
            this.TELEFONE.Click += new System.EventHandler(this.label5_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(116, 91);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(116, 125);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(116, 157);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox3.TabIndex = 7;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(116, 191);
            this.maskedTextBox4.Mask = "(99)99999-9999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CadastrarBotao
            // 
            this.CadastrarBotao.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
            this.CadastrarBotao.Location = new System.Drawing.Point(0, 309);
            this.CadastrarBotao.Name = "CadastrarBotao";
            this.CadastrarBotao.Size = new System.Drawing.Size(275, 54);
            this.CadastrarBotao.TabIndex = 10;
            this.CadastrarBotao.Text = "CADASTRAR";
            this.CadastrarBotao.UseVisualStyleBackColor = true;
            this.CadastrarBotao.Click += new System.EventHandler(this.button2_Click);
            // 
            // VoltarBotao
            // 
            this.VoltarBotao.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
            this.VoltarBotao.Location = new System.Drawing.Point(0, 369);
            this.VoltarBotao.Name = "VoltarBotao";
            this.VoltarBotao.Size = new System.Drawing.Size(275, 54);
            this.VoltarBotao.TabIndex = 11;
            this.VoltarBotao.Text = "VOLTAR";
            this.VoltarBotao.UseVisualStyleBackColor = true;
            this.VoltarBotao.Click += new System.EventHandler(this.VoltarBotao_Click);
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 450);
            this.Controls.Add(this.VoltarBotao);
            this.Controls.Add(this.CadastrarBotao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.TELEFONE);
            this.Controls.Add(this.RG);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.CODIGO);
            this.Controls.Add(this.label1);
            this.Name = "cadastrar";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CODIGO;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.Label RG;
        private System.Windows.Forms.Label TELEFONE;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CadastrarBotao;
        private System.Windows.Forms.Button VoltarBotao;
    }
}