namespace hopgomb
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
            this.xertek = new System.Windows.Forms.TextBox();
            this.yertek = new System.Windows.Forms.TextBox();
            this.Hop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // xertek
            // 
            this.xertek.Location = new System.Drawing.Point(253, 33);
            this.xertek.Name = "xertek";
            this.xertek.Size = new System.Drawing.Size(100, 20);
            this.xertek.TabIndex = 2;
            // 
            // yertek
            // 
            this.yertek.Location = new System.Drawing.Point(253, 54);
            this.yertek.Name = "yertek";
            this.yertek.Size = new System.Drawing.Size(100, 20);
            this.yertek.TabIndex = 3;
            // 
            // Hop
            // 
            this.Hop.Location = new System.Drawing.Point(349, 132);
            this.Hop.Name = "Hop";
            this.Hop.Size = new System.Drawing.Size(75, 23);
            this.Hop.TabIndex = 4;
            this.Hop.Text = "ugrik";
            this.Hop.UseVisualStyleBackColor = true;
            this.Hop.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "A megadott Koórdinátákra nem tudok ugrani";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hop);
            this.Controls.Add(this.yertek);
            this.Controls.Add(this.xertek);
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
        private System.Windows.Forms.TextBox xertek;
        private System.Windows.Forms.TextBox yertek;
        private System.Windows.Forms.Button Hop;
        private System.Windows.Forms.Label label3;
    }
}

