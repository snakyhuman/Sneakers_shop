using ParserLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        MarketItems Items = new MarketItems();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        richTextBox1.Text = (Items = MarketItems.Import(fd.FileName)).ToList().ToString();
                    }
                    catch
                    {
                        richTextBox1.Text = "Говно твой код";
                    }
                }
            }
        }
    }
}
