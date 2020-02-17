namespace ElsoWinForm
{
    partial class Urlap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urlap));
            this.modositogomb = new System.Windows.Forms.Button();
            this.szoveg = new System.Windows.Forms.Label();
            this.bevitelimezo = new System.Windows.Forms.TextBox();
            this.KimenoSzoveg = new System.Windows.Forms.TextBox();
            this.eltuntet = new System.Windows.Forms.Button();
            this.kilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modositogomb
            // 
            this.modositogomb.BackColor = System.Drawing.Color.Red;
            this.modositogomb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modositogomb.Location = new System.Drawing.Point(30, 48);
            this.modositogomb.Name = "modositogomb";
            this.modositogomb.Size = new System.Drawing.Size(82, 23);
            this.modositogomb.TabIndex = 0;
            this.modositogomb.Text = "módosító gomb";
            this.modositogomb.UseVisualStyleBackColor = false;
            this.modositogomb.Click += new System.EventHandler(this.modositogomb_Click_1);
            // 
            // szoveg
            // 
            this.szoveg.BackColor = System.Drawing.Color.Black;
            this.szoveg.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szoveg.ForeColor = System.Drawing.Color.DarkRed;
            this.szoveg.Location = new System.Drawing.Point(-1, -1);
            this.szoveg.Name = "szoveg";
            this.szoveg.Size = new System.Drawing.Size(150, 30);
            this.szoveg.TabIndex = 1;
            this.szoveg.Text = "Riddim Or Die";
            this.szoveg.Click += new System.EventHandler(this.label1_Click);
            // 
            // bevitelimezo
            // 
            this.bevitelimezo.Location = new System.Drawing.Point(135, 51);
            this.bevitelimezo.Multiline = true;
            this.bevitelimezo.Name = "bevitelimezo";
            this.bevitelimezo.Size = new System.Drawing.Size(100, 20);
            this.bevitelimezo.TabIndex = 2;
            this.bevitelimezo.TextChanged += new System.EventHandler(this.bevitelimezo_TextChanged);
            // 
            // KimenoSzoveg
            // 
            this.KimenoSzoveg.Location = new System.Drawing.Point(135, 77);
            this.KimenoSzoveg.Name = "KimenoSzoveg";
            this.KimenoSzoveg.Size = new System.Drawing.Size(100, 20);
            this.KimenoSzoveg.TabIndex = 3;
            // 
            // eltuntet
            // 
            this.eltuntet.Location = new System.Drawing.Point(37, 74);
            this.eltuntet.Name = "eltuntet";
            this.eltuntet.Size = new System.Drawing.Size(75, 23);
            this.eltuntet.TabIndex = 4;
            this.eltuntet.Text = "eltüntet";
            this.eltuntet.UseVisualStyleBackColor = true;
            this.eltuntet.Click += new System.EventHandler(this.eltuntet_Click);
            // 
            // kilep
            // 
            this.kilep.Location = new System.Drawing.Point(37, 103);
            this.kilep.Name = "kilep";
            this.kilep.Size = new System.Drawing.Size(75, 23);
            this.kilep.TabIndex = 5;
            this.kilep.Text = "Kilépés";
            this.kilep.UseVisualStyleBackColor = true;
            this.kilep.Click += new System.EventHandler(this.kilep_Click);
            this.kilep.MouseEnter += new System.EventHandler(this.kilep_MouseEnter);
            // 
            // Urlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 304);
            this.Controls.Add(this.kilep);
            this.Controls.Add(this.eltuntet);
            this.Controls.Add(this.KimenoSzoveg);
            this.Controls.Add(this.bevitelimezo);
            this.Controls.Add(this.szoveg);
            this.Controls.Add(this.modositogomb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urlap";
            this.Text = "Urlap";
            this.Load += new System.EventHandler(this.Urlappp_Load);
            this.MouseEnter += new System.EventHandler(this.belépett_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Urlap_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Urlap_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modositogomb;
        private System.Windows.Forms.Label szoveg;
        private System.Windows.Forms.TextBox bevitelimezo;
        private System.Windows.Forms.TextBox KimenoSzoveg;
        private System.Windows.Forms.Button eltuntet;
        private System.Windows.Forms.Button kilep;
    }
}

