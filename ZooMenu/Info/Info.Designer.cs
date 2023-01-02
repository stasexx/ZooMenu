namespace ZooMenu
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTableName = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxForSearch = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.comboBoxFilterAge = new System.Windows.Forms.ComboBox();
            this.comboBoxForCaloric = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterWeight = new System.Windows.Forms.ComboBox();
            this.comboBoxCalories = new System.Windows.Forms.ComboBox();
            this.comboBoxForKind = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelForAnimalAge = new System.Windows.Forms.Label();
            this.labelForAnimalWeight = new System.Windows.Forms.Label();
            this.labelForAnimalCalories = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(605, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBoxTableName
            // 
            this.comboBoxTableName.FormattingEnabled = true;
            this.comboBoxTableName.Location = new System.Drawing.Point(677, 86);
            this.comboBoxTableName.Name = "comboBoxTableName";
            this.comboBoxTableName.Size = new System.Drawing.Size(130, 21);
            this.comboBoxTableName.TabIndex = 3;
            this.comboBoxTableName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "За зрозтанням",
            "За зменшенням"});
            this.comboBox3.Location = new System.Drawing.Point(755, 225);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(130, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "ВІДСОРТУВАТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(755, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBoxForSearch
            // 
            this.comboBoxForSearch.FormattingEnabled = true;
            this.comboBoxForSearch.Location = new System.Drawing.Point(605, 136);
            this.comboBoxForSearch.Name = "comboBoxForSearch";
            this.comboBoxForSearch.Size = new System.Drawing.Size(129, 21);
            this.comboBoxForSearch.TabIndex = 7;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(677, 179);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(151, 20);
            this.Search.TabIndex = 8;
            this.Search.Text = "ПОШУК";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // comboBoxFilterAge
            // 
            this.comboBoxFilterAge.FormattingEnabled = true;
            this.comboBoxFilterAge.Items.AddRange(new object[] {
            "<3",
            "3-5",
            ">5"});
            this.comboBoxFilterAge.Location = new System.Drawing.Point(606, 382);
            this.comboBoxFilterAge.Name = "comboBoxFilterAge";
            this.comboBoxFilterAge.Size = new System.Drawing.Size(128, 21);
            this.comboBoxFilterAge.TabIndex = 11;
            // 
            // comboBoxForCaloric
            // 
            this.comboBoxForCaloric.FormattingEnabled = true;
            this.comboBoxForCaloric.Items.AddRange(new object[] {
            "<100",
            "100-300",
            ">300"});
            this.comboBoxForCaloric.Location = new System.Drawing.Point(753, 397);
            this.comboBoxForCaloric.Name = "comboBoxForCaloric";
            this.comboBoxForCaloric.Size = new System.Drawing.Size(130, 21);
            this.comboBoxForCaloric.TabIndex = 12;
            // 
            // comboBoxFilterWeight
            // 
            this.comboBoxFilterWeight.FormattingEnabled = true;
            this.comboBoxFilterWeight.Items.AddRange(new object[] {
            "<20",
            "20-100",
            ">100"});
            this.comboBoxFilterWeight.Location = new System.Drawing.Point(606, 420);
            this.comboBoxFilterWeight.Name = "comboBoxFilterWeight";
            this.comboBoxFilterWeight.Size = new System.Drawing.Size(128, 21);
            this.comboBoxFilterWeight.TabIndex = 13;
            // 
            // comboBoxCalories
            // 
            this.comboBoxCalories.FormattingEnabled = true;
            this.comboBoxCalories.Items.AddRange(new object[] {
            "<1000",
            "1000-3000",
            ">3000"});
            this.comboBoxCalories.Location = new System.Drawing.Point(606, 457);
            this.comboBoxCalories.Name = "comboBoxCalories";
            this.comboBoxCalories.Size = new System.Drawing.Size(128, 21);
            this.comboBoxCalories.TabIndex = 15;
            // 
            // comboBoxForKind
            // 
            this.comboBoxForKind.FormattingEnabled = true;
            this.comboBoxForKind.Items.AddRange(new object[] {
            "М\'ясоїд",
            "Травоїд"});
            this.comboBoxForKind.Location = new System.Drawing.Point(755, 442);
            this.comboBoxForKind.Name = "comboBoxForKind";
            this.comboBoxForKind.Size = new System.Drawing.Size(128, 21);
            this.comboBoxForKind.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "ЗАСТОСУВАТИ ФІЛЬТР";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(758, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "ЗАСТОСУВАТИ ФІЛЬТР";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelForAnimalAge
            // 
            this.labelForAnimalAge.AutoSize = true;
            this.labelForAnimalAge.Location = new System.Drawing.Point(613, 366);
            this.labelForAnimalAge.Name = "labelForAnimalAge";
            this.labelForAnimalAge.Size = new System.Drawing.Size(22, 13);
            this.labelForAnimalAge.TabIndex = 19;
            this.labelForAnimalAge.Text = "Вік";
            // 
            // labelForAnimalWeight
            // 
            this.labelForAnimalWeight.AutoSize = true;
            this.labelForAnimalWeight.Location = new System.Drawing.Point(613, 406);
            this.labelForAnimalWeight.Name = "labelForAnimalWeight";
            this.labelForAnimalWeight.Size = new System.Drawing.Size(31, 13);
            this.labelForAnimalWeight.TabIndex = 20;
            this.labelForAnimalWeight.Text = "Вага";
            // 
            // labelForAnimalCalories
            // 
            this.labelForAnimalCalories.AutoSize = true;
            this.labelForAnimalCalories.Location = new System.Drawing.Point(613, 442);
            this.labelForAnimalCalories.Name = "labelForAnimalCalories";
            this.labelForAnimalCalories.Size = new System.Drawing.Size(116, 13);
            this.labelForAnimalCalories.TabIndex = 21;
            this.labelForAnimalCalories.Text = "Денна норма калорій";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(755, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Калорійність";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(843, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(821, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(658, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Оберіть талбицю ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(613, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Поле для пошуку";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(602, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Поле для сортування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Вид";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(897, 532);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelForAnimalCalories);
            this.Controls.Add(this.labelForAnimalWeight);
            this.Controls.Add(this.labelForAnimalAge);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxForKind);
            this.Controls.Add(this.comboBoxCalories);
            this.Controls.Add(this.comboBoxFilterWeight);
            this.Controls.Add(this.comboBoxForCaloric);
            this.Controls.Add(this.comboBoxFilterAge);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.comboBoxForSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBoxTableName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxTableName;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxForSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox comboBoxFilterAge;
        private System.Windows.Forms.ComboBox comboBoxForCaloric;
        private System.Windows.Forms.ComboBox comboBoxFilterWeight;
        private System.Windows.Forms.ComboBox comboBoxCalories;
        private System.Windows.Forms.ComboBox comboBoxForKind;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelForAnimalAge;
        private System.Windows.Forms.Label labelForAnimalWeight;
        private System.Windows.Forms.Label labelForAnimalCalories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}