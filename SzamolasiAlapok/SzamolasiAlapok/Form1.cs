using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzamolasiAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void szamol_Click(object sender, EventArgs e)
        {
           
            double a = double.Parse(aoldal.Text);
            
            double b = double.Parse(boldal.Text);

            double c = Math.Sqrt(Math.Pow(a, 2)+ (Math.Pow(b, 2) ));

            double kerulet = a + b + c;
            double terulet = a + b / 2;
            string kiiras= $"c-oldal {c:F2}\n Kerület: {kerulet:F2}\n terület: {terulet:F2}";
            eredmenyek.Text = kiiras;
        }
    }
}
