namespace Praktinis_Darbas
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
            this.buttonAtlRankas = new System.Windows.Forms.Button();
            this.buttonAtlAntPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAtlRankas
            // 
            this.buttonAtlRankas.Location = new System.Drawing.Point(76, 75);
            this.buttonAtlRankas.Name = "buttonAtlRankas";
            this.buttonAtlRankas.Size = new System.Drawing.Size(119, 23);
            this.buttonAtlRankas.TabIndex = 0;
            this.buttonAtlRankas.Text = "Atl. i rankas";
            this.buttonAtlRankas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtlRankas.UseVisualStyleBackColor = true;
            this.buttonAtlRankas.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAtlAntPop
            // 
            this.buttonAtlAntPop.Location = new System.Drawing.Point(76, 144);
            this.buttonAtlAntPop.Name = "buttonAtlAntPop";
            this.buttonAtlAntPop.Size = new System.Drawing.Size(117, 23);
            this.buttonAtlAntPop.TabIndex = 1;
            this.buttonAtlAntPop.Text = "Atl. ant popieriaus";
            this.buttonAtlAntPop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtlAntPop.UseVisualStyleBackColor = true;
            this.buttonAtlAntPop.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 252);
            this.Controls.Add(this.buttonAtlAntPop);
            this.Controls.Add(this.buttonAtlRankas);
            this.Name = "Form1";
            this.Text = "Atlyginimpo skaiciuokle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAtlRankas;
        private System.Windows.Forms.Button buttonAtlAntPop;
    }
}

