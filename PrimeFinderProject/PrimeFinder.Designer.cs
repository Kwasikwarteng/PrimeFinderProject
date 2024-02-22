namespace PrimeFinderProject
{
    partial class PrimeFinder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            listBoxPrimes1 = new ListBox();
            listBoxPrimes2 = new ListBox();
            btnPrimes1 = new Button();
            btnPrimes2 = new Button();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(126, 96);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(217, 23);
            txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(456, 96);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(217, 23);
            txtNumber2.TabIndex = 1;
            // 
            // listBoxPrimes1
            // 
            listBoxPrimes1.FormattingEnabled = true;
            listBoxPrimes1.ItemHeight = 15;
            listBoxPrimes1.Location = new Point(126, 157);
            listBoxPrimes1.Name = "listBoxPrimes1";
            listBoxPrimes1.Size = new Size(217, 199);
            listBoxPrimes1.TabIndex = 2;
            // 
            // listBoxPrimes2
            // 
            listBoxPrimes2.FormattingEnabled = true;
            listBoxPrimes2.ItemHeight = 15;
            listBoxPrimes2.Location = new Point(456, 157);
            listBoxPrimes2.Name = "listBoxPrimes2";
            listBoxPrimes2.Size = new Size(217, 199);
            listBoxPrimes2.TabIndex = 3;
            // 
            // btnPrimes1
            // 
            btnPrimes1.Location = new Point(126, 426);
            btnPrimes1.Name = "btnPrimes1";
            btnPrimes1.Size = new Size(217, 40);
            btnPrimes1.TabIndex = 4;
            btnPrimes1.Text = "Find Primes A";
            btnPrimes1.UseVisualStyleBackColor = true;
            btnPrimes1.Click += btnPrimes1_Click;
            // 
            // btnPrimes2
            // 
            btnPrimes2.Location = new Point(456, 426);
            btnPrimes2.Name = "btnPrimes2";
            btnPrimes2.Size = new Size(217, 40);
            btnPrimes2.TabIndex = 5;
            btnPrimes2.Text = "Find Primes B";
            btnPrimes2.UseVisualStyleBackColor = true;
            btnPrimes2.Click += btnPrimes2_Click;
            // 
            // PrimeFinder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 545);
            Controls.Add(btnPrimes2);
            Controls.Add(btnPrimes1);
            Controls.Add(listBoxPrimes2);
            Controls.Add(listBoxPrimes1);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "PrimeFinder";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private ListBox listBoxPrimes1;
        private ListBox listBoxPrimes2;
        private Button btnPrimes1;
        private Button btnPrimes2;
    }
}
