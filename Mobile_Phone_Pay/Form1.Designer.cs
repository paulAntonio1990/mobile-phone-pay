namespace Mobile_Phone_Pay
{
    partial class Form1
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
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnAbonamente = new System.Windows.Forms.Button();
            this.btnExtraOptiuni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(271, 68);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(260, 45);
            this.btnClienti.TabIndex = 0;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.BtnClienti_Click);
            // 
            // btnAbonamente
            // 
            this.btnAbonamente.Location = new System.Drawing.Point(271, 146);
            this.btnAbonamente.Name = "btnAbonamente";
            this.btnAbonamente.Size = new System.Drawing.Size(260, 45);
            this.btnAbonamente.TabIndex = 1;
            this.btnAbonamente.Text = "Abonamente";
            this.btnAbonamente.UseVisualStyleBackColor = true;
            this.btnAbonamente.Click += new System.EventHandler(this.BtnAbonamente_Click);
            // 
            // btnExtraOptiuni
            // 
            this.btnExtraOptiuni.Location = new System.Drawing.Point(271, 229);
            this.btnExtraOptiuni.Name = "btnExtraOptiuni";
            this.btnExtraOptiuni.Size = new System.Drawing.Size(260, 45);
            this.btnExtraOptiuni.TabIndex = 2;
            this.btnExtraOptiuni.Text = "Extra-optiuni";
            this.btnExtraOptiuni.UseVisualStyleBackColor = true;
            this.btnExtraOptiuni.Click += new System.EventHandler(this.BtnExtraOptiuni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExtraOptiuni);
            this.Controls.Add(this.btnAbonamente);
            this.Controls.Add(this.btnClienti);
            this.Name = "Form1";
            this.Text = "Abonati telefonici";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnAbonamente;
        private System.Windows.Forms.Button btnExtraOptiuni;
    }
}

