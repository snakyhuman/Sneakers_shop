namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CurrentItemGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentItemMetaTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentItemOption = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentItemQuantity = new System.Windows.Forms.TextBox();
            this.CurrentItemImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SavePhoto = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Parse_Button = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.NumericUpDown();
            this.To = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.PhotoAfterParse = new System.Windows.Forms.CheckBox();
            this.Reload = new System.Windows.Forms.CheckBox();
            this.ParseGrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.marketItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BrowButton = new System.Windows.Forms.Button();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.CurrentItemGroupBox.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentItemImage)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParseGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 853);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CurrentItemGroupBox);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(454, 853);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // CurrentItemGroupBox
            // 
            this.CurrentItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentItemGroupBox.Controls.Add(this.flowLayoutPanel3);
            this.CurrentItemGroupBox.Controls.Add(this.CurrentItemImage);
            this.CurrentItemGroupBox.Location = new System.Drawing.Point(3, 13);
            this.CurrentItemGroupBox.Name = "CurrentItemGroupBox";
            this.CurrentItemGroupBox.Size = new System.Drawing.Size(435, 493);
            this.CurrentItemGroupBox.TabIndex = 6;
            this.CurrentItemGroupBox.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.CurrentItemName);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.CurrentItemMetaTitle);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.CurrentItemOption);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.CurrentItemQuantity);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 430);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(429, 60);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Артикул";
            // 
            // CurrentItemName
            // 
            this.CurrentItemName.Enabled = false;
            this.CurrentItemName.Location = new System.Drawing.Point(57, 3);
            this.CurrentItemName.Name = "CurrentItemName";
            this.CurrentItemName.Size = new System.Drawing.Size(58, 20);
            this.CurrentItemName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заголовок";
            // 
            // CurrentItemMetaTitle
            // 
            this.CurrentItemMetaTitle.Enabled = false;
            this.CurrentItemMetaTitle.Location = new System.Drawing.Point(188, 3);
            this.CurrentItemMetaTitle.Name = "CurrentItemMetaTitle";
            this.CurrentItemMetaTitle.Size = new System.Drawing.Size(238, 20);
            this.CurrentItemMetaTitle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Размер";
            // 
            // CurrentItemOption
            // 
            this.CurrentItemOption.Enabled = false;
            this.CurrentItemOption.Location = new System.Drawing.Point(55, 29);
            this.CurrentItemOption.Name = "CurrentItemOption";
            this.CurrentItemOption.Size = new System.Drawing.Size(60, 20);
            this.CurrentItemOption.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Осталось пар";
            // 
            // CurrentItemQuantity
            // 
            this.CurrentItemQuantity.Enabled = false;
            this.CurrentItemQuantity.Location = new System.Drawing.Point(204, 29);
            this.CurrentItemQuantity.Name = "CurrentItemQuantity";
            this.CurrentItemQuantity.Size = new System.Drawing.Size(53, 20);
            this.CurrentItemQuantity.TabIndex = 8;
            // 
            // CurrentItemImage
            // 
            this.CurrentItemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CurrentItemImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentItemImage.Location = new System.Drawing.Point(3, 16);
            this.CurrentItemImage.Name = "CurrentItemImage";
            this.CurrentItemImage.Size = new System.Drawing.Size(429, 474);
            this.CurrentItemImage.TabIndex = 0;
            this.CurrentItemImage.TabStop = false;
            this.CurrentItemImage.Click += new System.EventHandler(this.CurrentItemImage_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.progressBar1);
            this.flowLayoutPanel4.Controls.Add(this.SavePhoto);
            this.flowLayoutPanel4.Controls.Add(this.Save_Button);
            this.flowLayoutPanel4.Controls.Add(this.Parse_Button);
            this.flowLayoutPanel4.Controls.Add(this.splitContainer2);
            this.flowLayoutPanel4.Controls.Add(this.BrowButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 512);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(435, 291);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Всего элементов: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(6, 34);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 1, 1, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(423, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // SavePhoto
            // 
            this.SavePhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.SavePhoto.Enabled = false;
            this.SavePhoto.Location = new System.Drawing.Point(1, 64);
            this.SavePhoto.Margin = new System.Windows.Forms.Padding(1);
            this.SavePhoto.Name = "SavePhoto";
            this.SavePhoto.Size = new System.Drawing.Size(221, 28);
            this.SavePhoto.TabIndex = 3;
            this.SavePhoto.Text = "Загрузить фото";
            this.SavePhoto.UseVisualStyleBackColor = true;
            this.SavePhoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Save_Button.Enabled = false;
            this.Save_Button.Location = new System.Drawing.Point(224, 64);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(205, 28);
            this.Save_Button.TabIndex = 1;
            this.Save_Button.Text = "Сохранить";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Parse_Button
            // 
            this.Parse_Button.Location = new System.Drawing.Point(1, 94);
            this.Parse_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Parse_Button.Name = "Parse_Button";
            this.Parse_Button.Size = new System.Drawing.Size(428, 28);
            this.Parse_Button.TabIndex = 0;
            this.Parse_Button.Text = "Парсить";
            this.Parse_Button.UseVisualStyleBackColor = true;
            this.Parse_Button.Click += new System.EventHandler(this.Parse_Button_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 126);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.From);
            this.splitContainer2.Panel1.Controls.Add(this.To);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PhotoAfterParse);
            this.splitContainer2.Panel2.Controls.Add(this.Reload);
            this.splitContainer2.Size = new System.Drawing.Size(426, 100);
            this.splitContainer2.SplitterDistance = 204;
            this.splitContainer2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ПАРСИТЬ СТРАНИЦЫ:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "C";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(31, 34);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(101, 20);
            this.From.TabIndex = 6;
            this.From.ValueChanged += new System.EventHandler(this.To_ValueChanged);
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(31, 58);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(101, 20);
            this.To.TabIndex = 8;
            this.To.ValueChanged += new System.EventHandler(this.To_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "По";
            // 
            // PhotoAfterParse
            // 
            this.PhotoAfterParse.AutoSize = true;
            this.PhotoAfterParse.Location = new System.Drawing.Point(13, 36);
            this.PhotoAfterParse.Name = "PhotoAfterParse";
            this.PhotoAfterParse.Size = new System.Drawing.Size(196, 17);
            this.PhotoAfterParse.TabIndex = 6;
            this.PhotoAfterParse.Text = "Сохранить фото после парсинга?";
            this.PhotoAfterParse.UseVisualStyleBackColor = true;
            // 
            // Reload
            // 
            this.Reload.AutoSize = true;
            this.Reload.Checked = true;
            this.Reload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Reload.Location = new System.Drawing.Point(13, 11);
            this.Reload.Margin = new System.Windows.Forms.Padding(1, 6, 1, 1);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(136, 17);
            this.Reload.TabIndex = 5;
            this.Reload.Text = "Обновление Таблицы";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.CheckedChanged += new System.EventHandler(this.Reload_CheckedChanged);
            // 
            // ParseGrid
            // 
            this.ParseGrid.AllowUserToAddRows = false;
            this.ParseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ParseGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ParseGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParseGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ParseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParseGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParseGrid.Location = new System.Drawing.Point(0, 0);
            this.ParseGrid.Margin = new System.Windows.Forms.Padding(1);
            this.ParseGrid.MinimumSize = new System.Drawing.Size(40, 40);
            this.ParseGrid.Name = "ParseGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParseGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ParseGrid.RowTemplate.Height = 40;
            this.ParseGrid.Size = new System.Drawing.Size(906, 853);
            this.ParseGrid.TabIndex = 1;
            this.ParseGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParseGrid_CellClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FindTextBox);
            this.flowLayoutPanel1.Controls.Add(this.Find);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 853);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1, 12, 1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1364, 46);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(3, 11);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(163, 20);
            this.FindTextBox.TabIndex = 9;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(172, 11);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 10;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Browser);
            this.splitContainer1.Panel2.Controls.Add(this.ParseGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1364, 853);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.TabIndex = 5;
            // 
            // marketItemBindingSource
            // 
            this.marketItemBindingSource.DataSource = typeof(ParserLib.MarketItem);
            // 
            // BrowButton
            // 
            this.BrowButton.Location = new System.Drawing.Point(3, 232);
            this.BrowButton.Name = "BrowButton";
            this.BrowButton.Size = new System.Drawing.Size(160, 23);
            this.BrowButton.TabIndex = 10;
            this.BrowButton.Text = "Админ-Панель";
            this.BrowButton.UseVisualStyleBackColor = true;
            this.BrowButton.Visible = false;
            this.BrowButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(906, 853);
            this.Browser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1364, 899);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Парсер";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.CurrentItemGroupBox.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentItemImage)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParseGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marketItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ParseGrid;
        private System.Windows.Forms.Button Parse_Button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource marketItemBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SavePhoto;
        private System.Windows.Forms.CheckBox Reload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox CurrentItemGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CurrentItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CurrentItemMetaTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentItemOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CurrentItemQuantity;
        private System.Windows.Forms.PictureBox CurrentItemImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown From;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown To;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox PhotoAfterParse;
        private System.Windows.Forms.Button BrowButton;
        private System.Windows.Forms.WebBrowser Browser;
    }
}

