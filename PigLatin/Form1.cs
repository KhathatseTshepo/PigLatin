using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            string word;
            string plversion;
            word = textBox1.Text;

            string FirstLetter = word.Substring(0, 1);
            string RestOfTheWord = word.Substring(1, word.Length  -1);

            plversion = RestOfTheWord + FirstLetter + "ay";
            lblAnswer.Text = String.Format("The pig Latin version is {0}", plversion);
        }
    }
}
