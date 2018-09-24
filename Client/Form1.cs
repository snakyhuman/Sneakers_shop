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

            //dataGridView2.DataSource = Imp_source;
            ParseGrid.DataSource = source;
        }



        private async void Parse_Button_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Maximum = MarketItems.PageCount("http://www.sports-lin777.com") * 16;
                timer1.Interval = 1000;
                timer1.Start();
                ParseGrid.ReadOnly = true;
                Parse_Button.Enabled = false;
                if (await Items.ParseAsync("http://www.sports-lin777.com") == true)
                {
                    MessageBox.Show("Парсинг закончен");
                    SavePhoto.Enabled = true;
                    ParseGrid.ReadOnly = false;
                    Parse_Button.Enabled = true;
                    Save_Button.Enabled = true;
                    Reload.Checked = false;
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
            label1.Text = "Всего элементов: " + Items.Count+" из~ "+ progressBar1.Maximum;
            if (progressBar1.Maximum >= Items.Count)                
            { progressBar1.Value = Items.Count; }
            progressBar1.Refresh();
            if (Reload.Checked)
            {  

                
                ParseGrid.Refresh();
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

  

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var a in Items)
                    {
                        WebClient client = new WebClient();
                        Uri uri = new Uri(a.Main_image);
                        client.DownloadFileAsync(uri, fd.SelectedPath + "/" + a.Model + ".jpg");
                       
                        //await Task.Run(() => a.GetPhoto().Save(fd.SelectedPath + "/" + a.Model+".jpg"));
                    }
                }
            }

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog fd = new OpenFileDialog())
        //    {
        //        fd.Filter = "Excel Documents|*.xlsx";
        //        if (fd.ShowDialog() == DialogResult.OK)
        //        {
        //            try
        //            {
        //                Imported = MarketItems.Import(fd.FileName);
        //                Imp_source.Clear();
        //                foreach (var a in Imported)
        //                {
        //                    Imp_source.Add(a);
        //                }
        //                if (Imported.Count != 0) button3.Enabled = true;
        //                dataGridView2.Refresh();
        //            }
        //            catch (Exception exception)
        //            {

        //                MessageBox.Show(exception.Message);
        //            }
        //        }
        //    }
        //}

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Excel Documents|*.xlsx";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    MarketItems.Export(fd.FileName, Items);
                }
            }                
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
           
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

        private void Reload_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void ParseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = source[ParseGrid.CurrentRow.Index];
            ParseGrid.CurrentRow.Selected = true;
            var CurrentItem =(MarketItem)a;
            CurrentItemGroupBox.Text = CurrentItem.Name;
            CurrentItemMetaTitle.Text = CurrentItem.Name;
            CurrentItemName.Text = CurrentItem.Model.ToString();
            CurrentItemOption.Text = CurrentItem.Option;
            CurrentItemQuantity.Text = CurrentItem.Quantity;
            await Task.Run(()=> CurrentItemImage.BackgroundImage = CurrentItem.GetPhoto());
        }

        private void CurrentItemImage_Click(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ParseGrid.RowCount; i++)
            {
                ParseGrid.Rows[i].Selected = false;
                for (int j = 0; j < ParseGrid.ColumnCount; j++)
                    if (ParseGrid.Rows[i].Cells[j].Value != null)
                        if (ParseGrid.Rows[i].Cells[j].Value.ToString().ToLower().Contains(FindTextBox.Text.ToLower()))
                        {
                            ParseGrid.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
