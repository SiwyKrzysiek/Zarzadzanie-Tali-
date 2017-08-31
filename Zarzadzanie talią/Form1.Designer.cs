namespace Zarzadzanie_talią
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.restoreDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.restoreDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zestaw 1. (10 kart)";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(13, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 242);
            this.listBox1.TabIndex = 1;
            // 
            // restoreDeck1
            // 
            this.restoreDeck1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restoreDeck1.Location = new System.Drawing.Point(12, 281);
            this.restoreDeck1.Name = "restoreDeck1";
            this.restoreDeck1.Size = new System.Drawing.Size(121, 23);
            this.restoreDeck1.TabIndex = 2;
            this.restoreDeck1.Text = "Przywróć zestaw 1.";
            this.restoreDeck1.UseVisualStyleBackColor = true;
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shuffleDeck1.Location = new System.Drawing.Point(12, 310);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(121, 23);
            this.shuffleDeck1.TabIndex = 3;
            this.shuffleDeck1.Text = "Wymieszaj zestaw 1.";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(194, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 242);
            this.listBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zestaw 2. (52 kart)";
            // 
            // restoreDeck2
            // 
            this.restoreDeck2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreDeck2.Location = new System.Drawing.Point(194, 281);
            this.restoreDeck2.Name = "restoreDeck2";
            this.restoreDeck2.Size = new System.Drawing.Size(120, 23);
            this.restoreDeck2.TabIndex = 6;
            this.restoreDeck2.Text = "Przywróć zestaw 2.";
            this.restoreDeck2.UseVisualStyleBackColor = true;
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shuffleDeck2.Location = new System.Drawing.Point(194, 310);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(120, 23);
            this.shuffleDeck2.TabIndex = 7;
            this.shuffleDeck2.Text = "Wymieszaj zestaw 2.";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            // 
            // moveRight
            // 
            this.moveRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveRight.Location = new System.Drawing.Point(140, 99);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(47, 23);
            this.moveRight.TabIndex = 8;
            this.moveRight.Text = ">>";
            this.moveRight.UseVisualStyleBackColor = true;
            // 
            // moveLeft
            // 
            this.moveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveLeft.Location = new System.Drawing.Point(140, 138);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(47, 23);
            this.moveLeft.TabIndex = 9;
            this.moveLeft.Text = "<<";
            this.moveLeft.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 345);
            this.Controls.Add(this.moveLeft);
            this.Controls.Add(this.moveRight);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.restoreDeck2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.restoreDeck1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Zarządzanie talią";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button restoreDeck1;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restoreDeck2;
        private System.Windows.Forms.Button shuffleDeck2;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveLeft;
    }
}

