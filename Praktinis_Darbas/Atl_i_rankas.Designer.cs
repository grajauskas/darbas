namespace Praktinis_Darbas
{
    partial class Atl_i_rankas
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
            this.textBoxSuma = new System.Windows.Forms.TextBox();
            this.textBoxAutProc = new System.Windows.Forms.TextBox();
            this.buttonSkaicevimas = new System.Windows.Forms.Button();
            this.buttonIsjungimas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSuma
            // 
            this.textBoxSuma.Location = new System.Drawing.Point(130, 28);
            this.textBoxSuma.Name = "textBoxSuma";
            this.textBoxSuma.Size = new System.Drawing.Size(90, 20);
            this.textBoxSuma.TabIndex = 0;
            this.textBoxSuma.TextChanged += new System.EventHandler(this.textBoxSuma_TextChanged);
            // 
            // textBoxAutProc
            // 
            this.textBoxAutProc.Location = new System.Drawing.Point(130, 82);
            this.textBoxAutProc.Name = "textBoxAutProc";
            this.textBoxAutProc.Size = new System.Drawing.Size(90, 20);
            this.textBoxAutProc.TabIndex = 1;
            // 
            // buttonSkaicevimas
            // 
            this.buttonSkaicevimas.Location = new System.Drawing.Point(27, 152);
            this.buttonSkaicevimas.Name = "buttonSkaicevimas";
            this.buttonSkaicevimas.Size = new System.Drawing.Size(92, 23);
            this.buttonSkaicevimas.TabIndex = 2;
            this.buttonSkaicevimas.Text = "Skaiciuot";
            this.buttonSkaicevimas.UseVisualStyleBackColor = true;
            this.buttonSkaicevimas.Click += new System.EventHandler(this.buttonSkaicevimas_Click);
            // 
            // buttonIsjungimas
            // 
            this.buttonIsjungimas.AllowDrop = true;
            this.buttonIsjungimas.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonIsjungimas.Location = new System.Drawing.Point(158, 152);
            this.buttonIsjungimas.Name = "buttonIsjungimas";
            this.buttonIsjungimas.Size = new System.Drawing.Size(86, 23);
            this.buttonIsjungimas.TabIndex = 3;
            this.buttonIsjungimas.Text = "Uzdaryti";
            this.buttonIsjungimas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ivesti atl. i rankas ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proc. autoritiniu teisiu";
            // 
            // Atl_i_rankas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.buttonSkaicevimas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIsjungimas);
            this.Controls.Add(this.textBoxAutProc);
            this.Controls.Add(this.textBoxSuma);
            this.Name = "Atl_i_rankas";
            this.Text = "Atl_i_rankas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSuma;
        private System.Windows.Forms.TextBox textBoxAutProc;
        private System.Windows.Forms.Button buttonSkaicevimas;
        private System.Windows.Forms.Button buttonIsjungimas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}