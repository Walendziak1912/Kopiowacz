namespace Kopiowacz
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
            this.tbPathTo = new System.Windows.Forms.TextBox();
            this.bCopy = new System.Windows.Forms.Button();
            this.tbFilesList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPathTo
            // 
            this.tbPathTo.Location = new System.Drawing.Point(8, 25);
            this.tbPathTo.Name = "tbPathTo";
            this.tbPathTo.Size = new System.Drawing.Size(398, 20);
            this.tbPathTo.TabIndex = 0;
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(412, 22);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(71, 23);
            this.bCopy.TabIndex = 1;
            this.bCopy.Text = "Kopiuj";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // tbFilesList
            // 
            this.tbFilesList.Location = new System.Drawing.Point(5, 75);
            this.tbFilesList.Multiline = true;
            this.tbFilesList.Name = "tbFilesList";
            this.tbFilesList.Size = new System.Drawing.Size(478, 503);
            this.tbFilesList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scieżka kopiowania:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ścieżki plików do skopiowania:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilesList);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.tbPathTo);
            this.Name = "Form1";
            this.Text = "KOPIOWACZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPathTo;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.TextBox tbFilesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

