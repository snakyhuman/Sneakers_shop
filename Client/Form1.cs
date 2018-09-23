using ParserLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        MarketItems Items = new MarketItems();
        BindingSource source = new BindingSource();
        MarketItems Imported = new MarketItems();
        BindingSource Imp_source = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            dataGridView2.DataSource = Imp_source;
            dataGridView1.DataSource = source;
        }



        private async void Parse_Button_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Maximum = MarketItems.PageCount("http://www.sports-lin777.com") * 16;
                timer1.Interval = 500;
                timer1.Start();
                dataGridView1.ReadOnly = true;
                Parse_Button.Enabled = false;
                if (await Items.ParseAsync("http://www.sports-lin777.com") == true)
                {
                    MessageBox.Show("Парсинг закончен");
                    button1.Enabled = true;
                    dataGridView1.ReadOnly = false;
                    Parse_Button.Enabled = true;
                    button4.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Нет подключения к Интернету!");
                Parse_Button.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Всего элементов: " + Items.Count;
            if (checkBox1.Checked)
            {

                progressBar1.Value = Items.Count;
                progressBar1.Refresh();
                dataGridView1.Refresh();
                //BindingSource source = new BindingSource(Items.ToArray(),"");
                // source.Clear();            
                try
                {
                    foreach (var item in Items)
                    {
                        if (!source.Contains(item))
                        {
                            source.Add(item);
                            if (item.ChildrenItems.Count != 0)
                            {
                                foreach (var child in item.ChildrenItems)
                                {
                                    source.Add(child);
                                }
                            }
                        }
                    }
                }
                catch
                {

                }

            }

            //dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {




        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.Dock = DockStyle.Bottom;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var a in Items)
                    {
                        await Task.Run(() => a.GetPhoto().Save(fd.SelectedPath + "/" + a.Model+".jpg"));
                    }
                }
            }

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Excel Documents|*.xlsx";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Imported = MarketItems.Import(fd.FileName);
                        Imp_source.Clear();
                        foreach (var a in Imported)
                        {
                            Imp_source.Add(a);
                        }
                        if (Imported.Count != 0) button3.Enabled = true;
                        dataGridView2.Refresh();
                    }
                    catch (Exception exception)
                    {

                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            { fd.Filter = "Excel Documents|*.xlsx";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    MarketItems.Export(fd.FileName, Items);
                }
            }
                
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView2.Width = this.Width - flowLayoutPanel3.Width - 50;
            dataGridView2.Height = this.Height - 150;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = @"
                Программа разработана с целью парсинга информации с сайта http://www.sports-lin777.com
                Для других сайтов она не предназначена. Все вопросы по программе присылать на e-mail: snakyhuman@gmail.com
                ";
            MessageBox.Show(about);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Excel Documents|*.xlsx";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    MarketItems.Export(fd.FileName, Imported);
                }
            }
        }
    }
}
