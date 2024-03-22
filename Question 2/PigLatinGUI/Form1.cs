using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textInput.Text; // Collects word entered by user from textbox
            string pigLatin = word.Substring(1, word.Length -1) + word.Substring(0, 1) + "ay"; // Converts the user input to PigLatin
            textOutput.Text = pigLatin; // Assigns the label named "textOutput"
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textOutput_Click(object sender, EventArgs e)
        {

        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
