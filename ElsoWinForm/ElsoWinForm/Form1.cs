using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsoWinForm
{
    public partial class Urlap : Form
    {
        public string belepoSzoveg = "űrlap";
        public Urlap()
        {
            InitializeComponent();
        }

        private void Urlappp_Load(object sender, EventArgs e)
        {
            this.Text = (belepoSzoveg.ToUpper());
        }

        
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modositogomb_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void belépett_MouseEnter(object sender, EventArgs e)
        {
            this.Text = belepoSzoveg;
        }

        private void Urlap_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "kilépett";
        }

        private void Urlap_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Mozgás";
        }

        

        private void bevitelimezo_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int szam = rnd.Next(5);
           
            switch (szam)
            {
                case 0:
                    
                        this.BackColor = Color.Blue;
                    break;
                case 1:

                    this.BackColor = Color.Green;
                    break;

                case 2:

                    this.BackColor = Color.Red;
                    break;
                case 3:

                    this.BackColor = Color.Purple;
                    break;
                case 4:

                    this.BackColor = Color.Green;
                    break;

            }
        }

        private void modositogomb_Click_1(object sender, EventArgs e)
        {

            /*  if (eltuntet.Visible == true)
              {
                  eltuntet.Visible = false;
              }
              else
              {
                  eltuntet.Visible = true;
              }

              */
            eltuntet.Visible = !eltuntet.Visible;

        }

        private void kilep_Click(object sender, EventArgs e)
        {
            



        }

        private void eltuntet_Click(object sender, EventArgs e)
        {
            if (modositogomb.Enabled == true)
            {
                modositogomb.Enabled = false;
            }
            else
            {
                modositogomb.Enabled = true;
            }
        }

        private void kilep_MouseEnter(object sender, EventArgs e)
        {
            int szelesseg = this.Size.Width - kilep.Width - 10;
            int magassag = this.Size.Height - kilep.Height - 10;

            Random rnd = new Random();

            int x = rnd.Next(szelesseg);
            int y = rnd.Next(magassag);
            kilep.Location = new Point(x, y);

        }
    }
}
