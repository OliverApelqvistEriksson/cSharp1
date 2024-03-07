using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hund hund1 = new Hund();
            hund1.setPäls("grön");
            Console.WriteLine(hund1.getPäls());
            hund1.ben = 4;
            Console.WriteLine(hund1.ben);

            main_character mc = new main_character("", "", "", 18, "", "", true, true, 5);



        }
    }
}
