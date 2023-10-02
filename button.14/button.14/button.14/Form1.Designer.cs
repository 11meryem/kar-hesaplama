namespace button._14
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkar = new System.Windows.Forms.Label();
            this.txtalis = new System.Windows.Forms.TextBox();
            this.txtsatis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alış Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satış Fiyatı";
            // 
            // lblkar
            // 
            this.lblkar.AutoSize = true;
            this.lblkar.Location = new System.Drawing.Point(130, 181);
            this.lblkar.Name = "lblkar";
            this.lblkar.Size = new System.Drawing.Size(76, 13);
            this.lblkar.TabIndex = 2;
            this.lblkar.Text = "TOPLAM KAR";
            // 
            // txtalis
            // 
            this.txtalis.Location = new System.Drawing.Point(106, 44);
            this.txtalis.Name = "txtalis";
            this.txtalis.Size = new System.Drawing.Size(100, 20);
            this.txtalis.TabIndex = 3;
            // 
            // txtsatis
            // 
            this.txtsatis.Location = new System.Drawing.Point(106, 86);
            this.txtsatis.Name = "txtsatis";
            this.txtsatis.Size = new System.Drawing.Size(100, 20);
            this.txtsatis.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAR HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsatis);
            this.Controls.Add(this.txtalis);
            this.Controls.Add(this.lblkar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkar;
        private System.Windows.Forms.TextBox txtalis;
        private System.Windows.Forms.TextBox txtsatis;
        private System.Windows.Forms.Button button1;
    }
}

