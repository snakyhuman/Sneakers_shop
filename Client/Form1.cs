using ParserLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public Form1()
        {
            InitializeComponent();

            //dataGridView2.DataSource = Imp_source;
            ParseGrid.DataSource = source;

            try
            {
                int maxCount = MarketItems.PageCount("http://www.sports-lin777.com");


                From.Maximum = maxCount;
                To.Maximum = maxCount;
                From.Minimum = 1;
                To.Minimum = 1;
                To.Value = maxCount;
            }
            catch
            {
                MessageBox.Show("Сайт не работает. \nНет соединения!");
                this.Close();
            }
            Browser.Visible = false;
            //Browser.Url = new Uri("https://krosshop24.ru/admin");
        }



        private async void Parse_Button_Click(object sender, EventArgs e)
        {
            try
            {

                progressBar1.Maximum = ((int)(To.Value - From.Value) + 1) * 16;



                timer1.Interval = 1000;
                timer1.Start();
                ParseGrid.ReadOnly = true;
                Parse_Button.Enabled = false;
                From.Enabled = false;
                To.Enabled = false;
                PhotoAfterParse.Enabled = false;
                if (await Items.ParseAsync("http://www.sports-lin777.com", (int)From.Value, (int)To.Value) == true)
                {
                    MessageBox.Show("Парсинг закончен");
                    SavePhoto.Enabled = true;
                    Save_Button.Enabled = true;
                    Reload.Checked = false;
                    if (PhotoAfterParse.Enabled)
                    {
                        button1_Click(sender, e);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Нет подключения к Интернету!");
            }
            ParseGrid.ReadOnly = false;
            Parse_Button.Enabled = true;
            From.Enabled = true;
            To.Enabled = true;
            PhotoAfterParse.Enabled = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            float persent = 0;
            if (Items.Count > 0)
            {
                try
                {
                    persent = (float)((float)Items.Count / ((float)progressBar1.Maximum / 100));
                }
                catch { }

            }

            label1.Text = "Всего элементов: " + Items.Count + " из " + progressBar1.Maximum + "                       " + persent + "%";
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
                fd.Title = "Выберите EXCEL файл, в который хотите сохранить результаты!";
                fd.Filter = "Excel Documents|*.xlsx";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    MarketItems.Export(fd.FileName, Items);
                    Process.Start(fd.FileName);
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
            var CurrentItem = (MarketItem)a;
            CurrentItemGroupBox.Text = CurrentItem.Name;
            CurrentItemMetaTitle.Text = CurrentItem.Name;
            CurrentItemName.Text = CurrentItem.Model.ToString();
            CurrentItemOption.Text = CurrentItem.Option;
            CurrentItemQuantity.Text = CurrentItem.Quantity;
            await Task.Run(() => CurrentItemImage.BackgroundImage = CurrentItem.GetPhoto());
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

        private void To_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (To.Value < From.Value)
                {
                    From.Value = To.Value;
                }
            }
            catch { }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public string send(string url, string par)
        {
            String secondStepForm3 = par;
            HttpWebRequest request3 = (HttpWebRequest)WebRequest.Create(url);
            request3.UserAgent = "Opera/9.80";
            request3.Method = "POST";
            request3.ContentType = "application/x-www-form-urlencoded";
            byte[] EncodedPostParams3 = Encoding.Default.GetBytes(secondStepForm3);
            request3.ContentLength = EncodedPostParams3.Length;
            request3.GetRequestStream().Write(EncodedPostParams3, 0, EncodedPostParams3.Length);
            request3.GetRequestStream().Close();
            HttpWebResponse response = (HttpWebResponse)request3.GetResponse();
            string lol = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            return lol;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Browser.Visible = !Browser.Visible;
            //if (Browser.Visible)
            //{
            //    BrowButton.Text = "Закрыть панель";
            //}
            //else BrowButton.Text = "Админ-Панель";
            //Reload.Checked = false;

            //string loginURI = "https://krosshop24.ru/admin/index.php?route=common/login";
            //string username = "admin";
            //string password = "kDa7f42L";
            //string reqString = "username=" + username + "&password=" + password;
            //byte[] requestData = Encoding.UTF8.GetBytes(reqString);
            //CookieContainer container = new CookieContainer();

            //var request = (HttpWebRequest)WebRequest.Create(loginURI);
            //request.AllowAutoRedirect = true;
            //request.Method = "POST";
            //request.CookieContainer = container;
            //request.ContentType = "application/x-www-form-urlencoded";
            //request.ContentLength = requestData.Length;

            //using (Stream S = request.GetRequestStream())
            //    S.Write(requestData, 0, requestData.Length);

            //using (var response = (HttpWebResponse)request.GetResponse())
            //{
            //    if (response.StatusCode == HttpStatusCode.OK)
            //    {
            //     //Browser. = WebRequest.Create("https://krosshop24.ru/admin").GetResponse();                    
            //    }
            //    var newPageCode = new StreamReader(response.GetResponseStream()).ReadToEnd();
            //}







        }
    }
}

