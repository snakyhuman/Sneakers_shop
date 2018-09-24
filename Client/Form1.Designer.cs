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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Reload = new System.Windows.Forms.CheckBox();
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SavePhoto = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Parse_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ParseGrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.marketItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.CurrentItemGroupBox.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentItemImage)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
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
            this.flowLayoutPanel2.Controls.Add(this.Reload);
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
            // Reload
            // 
            this.Reload.AutoSize = true;
            this.Reload.Checked = true;
            this.Reload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Reload.Location = new System.Drawing.Point(1, 11);
            this.Reload.Margin = new System.Windows.Forms.Padding(1);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(224, 17);
            this.Reload.TabIndex = 5;
            this.Reload.Text = "Обновлять данные по мере Парсинга?";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.CheckedChanged += new System.EventHandler(this.Reload_CheckedChanged);
            // 
            // CurrentItemGroupBox
            // 
            this.CurrentItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentItemGroupBox.Controls.Add(this.flowLayoutPanel3);
            this.CurrentItemGroupBox.Controls.Add(this.CurrentItemImage);
            this.CurrentItemGroupBox.Location = new System.Drawing.Point(3, 32);
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
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 531);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(435, 137);
            this.flowLayoutPanel4.TabIndex = 7;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParseGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.splitContainer1.Panel2.Controls.Add(this.ParseGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1364, 853);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.TabIndex = 5;
            // 
            // marketItemBindingSource
            // 
            this.marketItemBindingSource.DataSource = typeof(ParserLib.MarketItem);
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
            this.flowLayoutPanel2.PerformLayout();
            this.CurrentItemGroupBox.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentItemImage)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
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
    }
}

