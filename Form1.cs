using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Ball
{
    public partial class Form1 : Form
    {


        // parameter festlegen
        DialogResult dialog = new DialogResult();
        public static string[] antworten = {"Yes", "No", " Cannot predict now.", " erst wenn der FC den Trippel macht", "Vielleicht",
            "in 3 Jahren", "Darüber streiten sich die Gelehrten","Don't count on it.", "Without a doubt.", "As I see it, yes.", " Ask again later.", "My reply is no.",
            "My sources say no.", "Most likely.", " Very doubtful.", "Das glaubst du doch selber nicht", "Signs point to yes.", "You may rely on it.", "Outlook not so good.","My sources say yes."};

        public static Random rnd = new Random();
        public static int maxAntwort = antworten.Length;
        public static int randomAntwort = rnd.Next(0, antworten.Length);




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            antwortBox.Text = antworten[randomAntwort];
            randomAntwort = rnd.Next(0, antworten.Length);
    }

        private void antwortBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void frageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frageBox.Text = " ";
            randomAntwort = rnd.Next(0, antworten.Length);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dialog = MessageBox.Show("Do you want to close?", "Obacht", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                dialog = MessageBox.Show(".. Okay, war schön mit dir, machet jood ävver net zu oft", "2ter Alarm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    System.Environment.Exit(1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frageBox.Text = " ";
            antwortBox.Text = " ";
            randomAntwort = rnd.Next(0, antworten.Length);
        }
    }
}
