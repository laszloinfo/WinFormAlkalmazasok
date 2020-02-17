namespace SzamolasiAlapok
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
            this.aoldal = new System.Windows.Forms.TextBox();
            this.boldal = new System.Windows.Forms.TextBox();
            this.eredmenyek = new System.Windows.Forms.TextBox();
            this.szamol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aoldal
            // 
            this.aoldal.Location = new System.Drawing.Point(417, 61);
            this.aoldal.Name = "aoldal";
            this.aoldal.Size = new System.Drawing.Size(100, 20);
            this.aoldal.TabIndex = 0;
            // 
            // boldal
            // 
            this.boldal.Location = new System.Drawing.Point(417, 101);
            this.boldal.Name = "boldal";
            this.boldal.Size = new System.Drawing.Size(100, 20);
            this.boldal.TabIndex = 1;
            // 
            // eredmenyek
            // 
            this.eredmenyek.Location = new System.Drawing.Point(417, 139);
            this.eredmenyek.Multiline = true;
            this.eredmenyek.Name = "eredmenyek";
            this.eredmenyek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eredmenyek.Size = new System.Drawing.Size(100, 56);
            this.eredmenyek.TabIndex = 2;
            // 
            // szamol
            // 
            this.szamol.Location = new System.Drawing.Point(254, 58);
            this.szamol.Name = "szamol";
            this.szamol.Size = new System.Drawing.Size(75, 23);
            this.szamol.TabIndex = 3;
            this.szamol.Text = "számolás";
            this.szamol.UseVisualStyleBackColor = true;
            this.szamol.Click += new System.EventHandler(this.szamol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "a oldal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "b oldal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "eredmények:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szamol);
            this.Controls.Add(this.eredmenyek);
            this.Controls.Add(this.boldal);
            this.Controls.Add(this.aoldal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aoldal;
        private System.Windows.Forms.TextBox boldal;
        private System.Windows.Forms.TextBox eredmenyek;
        private System.Windows.Forms.Button szamol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

