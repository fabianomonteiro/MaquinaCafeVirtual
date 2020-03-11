namespace MaquinaCafeVirtual.WindowsForms
{
    partial class FormMaquinaCafeVirtual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaquinaCafeVirtual));
            this.buttonIniciarPreparo = new System.Windows.Forms.Button();
            this.buttonAdicionarMoeda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMoeda = new System.Windows.Forms.ComboBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDevolverSaldo = new System.Windows.Forms.Button();
            this.buttonRetirarTroco = new System.Windows.Forms.Button();
            this.labelTroco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxOpcoes = new System.Windows.Forms.GroupBox();
            this.buttonRetirarCafe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIniciarPreparo
            // 
            this.buttonIniciarPreparo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIniciarPreparo.Location = new System.Drawing.Point(16, 265);
            this.buttonIniciarPreparo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIniciarPreparo.Name = "buttonIniciarPreparo";
            this.buttonIniciarPreparo.Size = new System.Drawing.Size(120, 28);
            this.buttonIniciarPreparo.TabIndex = 0;
            this.buttonIniciarPreparo.Text = "Iniciar Preparo";
            this.buttonIniciarPreparo.UseVisualStyleBackColor = true;
            this.buttonIniciarPreparo.Click += new System.EventHandler(this.buttonIniciarPreparo_Click);
            // 
            // buttonAdicionarMoeda
            // 
            this.buttonAdicionarMoeda.Location = new System.Drawing.Point(13, 265);
            this.buttonAdicionarMoeda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarMoeda.Name = "buttonAdicionarMoeda";
            this.buttonAdicionarMoeda.Size = new System.Drawing.Size(141, 28);
            this.buttonAdicionarMoeda.TabIndex = 3;
            this.buttonAdicionarMoeda.Text = "Inserir Moeda";
            this.buttonAdicionarMoeda.UseVisualStyleBackColor = true;
            this.buttonAdicionarMoeda.Click += new System.EventHandler(this.buttonAdicionarMoeda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saldo:";
            // 
            // comboBoxMoeda
            // 
            this.comboBoxMoeda.FormattingEnabled = true;
            this.comboBoxMoeda.Location = new System.Drawing.Point(13, 234);
            this.comboBoxMoeda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMoeda.Name = "comboBoxMoeda";
            this.comboBoxMoeda.Size = new System.Drawing.Size(140, 24);
            this.comboBoxMoeda.TabIndex = 5;
            // 
            // labelSaldo
            // 
            this.labelSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSaldo.Location = new System.Drawing.Point(13, 53);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(141, 24);
            this.labelSaldo.TabIndex = 6;
            this.labelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonDevolverSaldo);
            this.groupBox1.Controls.Add(this.buttonRetirarTroco);
            this.groupBox1.Controls.Add(this.labelTroco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelSaldo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxMoeda);
            this.groupBox1.Controls.Add(this.buttonAdicionarMoeda);
            this.groupBox1.Location = new System.Drawing.Point(413, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(171, 308);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Moeda:";
            // 
            // buttonDevolverSaldo
            // 
            this.buttonDevolverSaldo.Location = new System.Drawing.Point(13, 80);
            this.buttonDevolverSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDevolverSaldo.Name = "buttonDevolverSaldo";
            this.buttonDevolverSaldo.Size = new System.Drawing.Size(141, 28);
            this.buttonDevolverSaldo.TabIndex = 10;
            this.buttonDevolverSaldo.Text = "Devolver Saldo";
            this.buttonDevolverSaldo.UseVisualStyleBackColor = true;
            this.buttonDevolverSaldo.Click += new System.EventHandler(this.buttonDevolverSaldo_Click);
            // 
            // buttonRetirarTroco
            // 
            this.buttonRetirarTroco.Location = new System.Drawing.Point(13, 169);
            this.buttonRetirarTroco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRetirarTroco.Name = "buttonRetirarTroco";
            this.buttonRetirarTroco.Size = new System.Drawing.Size(141, 28);
            this.buttonRetirarTroco.TabIndex = 9;
            this.buttonRetirarTroco.Text = "Retirar Troco";
            this.buttonRetirarTroco.UseVisualStyleBackColor = true;
            this.buttonRetirarTroco.Click += new System.EventHandler(this.buttonRetirarTroco_Click);
            // 
            // labelTroco
            // 
            this.labelTroco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTroco.Location = new System.Drawing.Point(13, 142);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(141, 24);
            this.labelTroco.TabIndex = 8;
            this.labelTroco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Troco:";
            // 
            // groupBoxOpcoes
            // 
            this.groupBoxOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOpcoes.Controls.Add(this.buttonRetirarCafe);
            this.groupBoxOpcoes.Controls.Add(this.buttonIniciarPreparo);
            this.groupBoxOpcoes.Location = new System.Drawing.Point(15, 114);
            this.groupBoxOpcoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOpcoes.Name = "groupBoxOpcoes";
            this.groupBoxOpcoes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOpcoes.Size = new System.Drawing.Size(393, 308);
            this.groupBoxOpcoes.TabIndex = 9;
            this.groupBoxOpcoes.TabStop = false;
            this.groupBoxOpcoes.Text = "Opções";
            // 
            // buttonRetirarCafe
            // 
            this.buttonRetirarCafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetirarCafe.Location = new System.Drawing.Point(258, 265);
            this.buttonRetirarCafe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRetirarCafe.Name = "buttonRetirarCafe";
            this.buttonRetirarCafe.Size = new System.Drawing.Size(120, 28);
            this.buttonRetirarCafe.TabIndex = 8;
            this.buttonRetirarCafe.Text = "Retirar Café";
            this.buttonRetirarCafe.UseVisualStyleBackColor = true;
            this.buttonRetirarCafe.Click += new System.EventHandler(this.buttonRetirarCafe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Maquina de Café Virtual";
            // 
            // labelMensagem
            // 
            this.labelMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMensagem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagem.Location = new System.Drawing.Point(133, 57);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(450, 44);
            this.labelMensagem.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaquinaCafeVirtual.WindowsForms.Properties.Resources.Cafe_Com_C_;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 98);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormMaquinaCafeVirtual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxOpcoes);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMaquinaCafeVirtual";
            this.Text = "Maquina de Café Virtual";
            this.Load += new System.EventHandler(this.FormMaquinaCafeVirtual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciarPreparo;
        private System.Windows.Forms.Button buttonAdicionarMoeda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMoeda;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxOpcoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Button buttonRetirarTroco;
        private System.Windows.Forms.Button buttonDevolverSaldo;
        private System.Windows.Forms.Button buttonRetirarCafe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

