using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metods.Leven leven = new metods.Leven();
            metods.Hamming hamming = new metods.Hamming();   
            metods.Diff diff = new metods.Diff();
            //var asd = leven.LevenshteinDistance("asd", "asd");
            //textBox1.Text = asd.ToString();

            var text1 = textBox1.Text.ToString();
            var text2 = textBox2.Text.ToString();

            var resLeven = leven.LevenshteinDistance(text1, text2);
            var resHam = hamming.HammingDistance(text1, text2);
            var resDiff = diff.Difff(text1, text2);

            var res = (resDiff + resHam + resDiff) / 3;

            string asd = resDiff.ToString() + " " + resHam.ToString() + " " + resDiff.ToString() + "\n" + res;


            textBox3.Text = asd.ToString();
            
        }
    }
}
