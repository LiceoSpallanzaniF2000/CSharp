namespace ProgettoTest
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.ifButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.forButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.sommaButt = new System.Windows.Forms.Button();
            this.aTxt = new System.Windows.Forms.TextBox();
            this.bTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ifButton
            // 
            this.ifButton.Location = new System.Drawing.Point(12, 12);
            this.ifButton.Name = "ifButton";
            this.ifButton.Size = new System.Drawing.Size(83, 31);
            this.ifButton.TabIndex = 0;
            this.ifButton.Text = "If button";
            this.ifButton.UseVisualStyleBackColor = true;
            this.ifButton.Click += new System.EventHandler(this.ifButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(12, 49);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(83, 31);
            this.switchButton.TabIndex = 1;
            this.switchButton.Text = "Switch button";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(12, 86);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(83, 31);
            this.forButton.TabIndex = 2;
            this.forButton.Text = "For button";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(235, 134);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(13, 13);
            this.result.TabIndex = 4;
            this.result.Text = "0";
            // 
            // sommaButt
            // 
            this.sommaButt.Location = new System.Drawing.Point(11, 125);
            this.sommaButt.Name = "sommaButt";
            this.sommaButt.Size = new System.Drawing.Size(83, 31);
            this.sommaButt.TabIndex = 5;
            this.sommaButt.Text = "Somma";
            this.sommaButt.UseVisualStyleBackColor = true;
            this.sommaButt.Click += new System.EventHandler(this.sommaButt_Click);
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(100, 131);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(43, 20);
            this.aTxt.TabIndex = 6;
            this.aTxt.Text = "0";
            // 
            // bTxt
            // 
            this.bTxt.Location = new System.Drawing.Point(167, 131);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(43, 20);
            this.bTxt.TabIndex = 7;
            this.bTxt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.sommaButt);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.ifButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ifButton;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button sommaButt;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

