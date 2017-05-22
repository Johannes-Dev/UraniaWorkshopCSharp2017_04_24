namespace TaschenrechnerPlusMinus
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonRechnen = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(73, 97);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(125, 20);
            this.textBoxZahl1.TabIndex = 0;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(285, 97);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(125, 20);
            this.textBoxZahl2.TabIndex = 1;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(204, 76);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(204, 105);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonRechnen
            // 
            this.buttonRechnen.Location = new System.Drawing.Point(416, 94);
            this.buttonRechnen.Name = "buttonRechnen";
            this.buttonRechnen.Size = new System.Drawing.Size(75, 23);
            this.buttonRechnen.TabIndex = 4;
            this.buttonRechnen.Text = "=";
            this.buttonRechnen.UseVisualStyleBackColor = true;
            this.buttonRechnen.Click += new System.EventHandler(this.buttonRechnen_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(521, 97);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 182);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonRechnen);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonRechnen;
        private System.Windows.Forms.Label labelResult;
    }
}

