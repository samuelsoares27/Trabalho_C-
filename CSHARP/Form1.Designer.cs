namespace CSHARP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.bt_processa = new System.Windows.Forms.Button();
            this.pbNova = new System.Windows.Forms.PictureBox();
            this.pbOrigi = new System.Windows.Forms.PictureBox();
            this.btNova = new System.Windows.Forms.Button();
            this.btOrigi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbNova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrigi)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(307, 46);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(84, 20);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Original";
            // 
            // lb2
            // 
            this.lb2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(1046, 46);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(116, 20);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Processada";
            // 
            // bt_processa
            // 
            this.bt_processa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_processa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_processa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_processa.Location = new System.Drawing.Point(584, 12);
            this.bt_processa.Name = "bt_processa";
            this.bt_processa.Size = new System.Drawing.Size(279, 41);
            this.bt_processa.TabIndex = 4;
            this.bt_processa.Text = "Processar em python";
            this.bt_processa.UseVisualStyleBackColor = true;
            this.bt_processa.Click += new System.EventHandler(this.bt_processa_Click);
            // 
            // pbNova
            // 
            this.pbNova.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNova.Image = global::CSHARP.Properties.Resources.branco1;
            this.pbNova.Location = new System.Drawing.Point(735, 69);
            this.pbNova.Name = "pbNova";
            this.pbNova.Size = new System.Drawing.Size(678, 444);
            this.pbNova.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNova.TabIndex = 1;
            this.pbNova.TabStop = false;
            // 
            // pbOrigi
            // 
            this.pbOrigi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbOrigi.Image = global::CSHARP.Properties.Resources.branco1;
            this.pbOrigi.Location = new System.Drawing.Point(28, 69);
            this.pbOrigi.Name = "pbOrigi";
            this.pbOrigi.Size = new System.Drawing.Size(678, 444);
            this.pbOrigi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrigi.TabIndex = 0;
            this.pbOrigi.TabStop = false;
            // 
            // btNova
            // 
            this.btNova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNova.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNova.Location = new System.Drawing.Point(999, 527);
            this.btNova.Name = "btNova";
            this.btNova.Size = new System.Drawing.Size(193, 41);
            this.btNova.TabIndex = 5;
            this.btNova.Text = "Carregar";
            this.btNova.UseVisualStyleBackColor = true;
            this.btNova.Click += new System.EventHandler(this.bt_Nova);
            // 
            // btOrigi
            // 
            this.btOrigi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOrigi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrigi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrigi.Location = new System.Drawing.Point(252, 527);
            this.btOrigi.Name = "btOrigi";
            this.btOrigi.Size = new System.Drawing.Size(193, 41);
            this.btOrigi.TabIndex = 6;
            this.btOrigi.Text = "Carregar";
            this.btOrigi.UseVisualStyleBackColor = true;
            this.btOrigi.Click += new System.EventHandler(this.bt_Origi);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1442, 580);
            this.Controls.Add(this.btOrigi);
            this.Controls.Add(this.btNova);
            this.Controls.Add(this.bt_processa);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pbNova);
            this.Controls.Add(this.pbOrigi);
            this.Name = "Form1";
            this.Text = "Processamento de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.pbNova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrigi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOrigi;
        private System.Windows.Forms.PictureBox pbNova;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button bt_processa;
        private System.Windows.Forms.Button btNova;
        private System.Windows.Forms.Button btOrigi;
    }
}

