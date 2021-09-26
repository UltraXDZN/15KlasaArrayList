
namespace _15KlasaArraylist
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
            this.listaAutaText = new System.Windows.Forms.TextBox();
            this.imeAutaText = new System.Windows.Forms.TextBox();
            this.unesiButton = new System.Windows.Forms.Button();
            this.noviAutoButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaAutaText
            // 
            this.listaAutaText.Location = new System.Drawing.Point(12, 84);
            this.listaAutaText.Multiline = true;
            this.listaAutaText.Name = "listaAutaText";
            this.listaAutaText.Size = new System.Drawing.Size(275, 215);
            this.listaAutaText.TabIndex = 0;
            // 
            // imeAutaText
            // 
            this.imeAutaText.Enabled = false;
            this.imeAutaText.Location = new System.Drawing.Point(13, 52);
            this.imeAutaText.Name = "imeAutaText";
            this.imeAutaText.Size = new System.Drawing.Size(170, 20);
            this.imeAutaText.TabIndex = 1;
            // 
            // unesiButton
            // 
            this.unesiButton.Enabled = false;
            this.unesiButton.Location = new System.Drawing.Point(212, 49);
            this.unesiButton.Name = "unesiButton";
            this.unesiButton.Size = new System.Drawing.Size(75, 23);
            this.unesiButton.TabIndex = 2;
            this.unesiButton.Text = "Unesi";
            this.unesiButton.UseVisualStyleBackColor = true;
            this.unesiButton.Click += new System.EventHandler(this.unesiButton_Click);
            // 
            // noviAutoButton
            // 
            this.noviAutoButton.Location = new System.Drawing.Point(13, 12);
            this.noviAutoButton.Name = "noviAutoButton";
            this.noviAutoButton.Size = new System.Drawing.Size(171, 22);
            this.noviAutoButton.TabIndex = 3;
            this.noviAutoButton.Text = "Novi Automobil";
            this.noviAutoButton.UseVisualStyleBackColor = true;
            this.noviAutoButton.Click += new System.EventHandler(this.noviAutoButton_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(13, 311);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(83, 19);
            this.obrisiButton.TabIndex = 4;
            this.obrisiButton.Text = "Obriši listu";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 342);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.noviAutoButton);
            this.Controls.Add(this.unesiButton);
            this.Controls.Add(this.imeAutaText);
            this.Controls.Add(this.listaAutaText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listaAutaText;
        private System.Windows.Forms.TextBox imeAutaText;
        private System.Windows.Forms.Button unesiButton;
        private System.Windows.Forms.Button noviAutoButton;
        private System.Windows.Forms.Button obrisiButton;
    }
}

