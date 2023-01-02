namespace ZooMenu.Report
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.buttonForParcel = new System.Windows.Forms.Button();
            this.buttonForSeasons = new System.Windows.Forms.Button();
            this.comboBoxForAnimal = new System.Windows.Forms.ComboBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zooDataSet = new ZooMenu.ZooDataSet();
            this.comboBoxForFirstFeed = new System.Windows.Forms.ComboBox();
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxForSecondFeed = new System.Windows.Forms.ComboBox();
            this.feedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxForThirdFeed = new System.Windows.Forms.ComboBox();
            this.feedBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new ZooMenu.ZooDataSetTableAdapters.AnimalTableAdapter();
            this.feedTableAdapter = new ZooMenu.ZooDataSetTableAdapters.FeedTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonForParcel
            // 
            this.buttonForParcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForParcel.Location = new System.Drawing.Point(212, 168);
            this.buttonForParcel.Name = "buttonForParcel";
            this.buttonForParcel.Size = new System.Drawing.Size(221, 106);
            this.buttonForParcel.TabIndex = 0;
            this.buttonForParcel.Text = "ЗВІТ ДЛЯ ТВАРИНИ";
            this.buttonForParcel.UseVisualStyleBackColor = true;
            this.buttonForParcel.Click += new System.EventHandler(this.buttonForParcel_Click);
            // 
            // buttonForSeasons
            // 
            this.buttonForSeasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForSeasons.Location = new System.Drawing.Point(212, 12);
            this.buttonForSeasons.Name = "buttonForSeasons";
            this.buttonForSeasons.Size = new System.Drawing.Size(221, 106);
            this.buttonForSeasons.TabIndex = 1;
            this.buttonForSeasons.Text = "ЗВІТ ПО СЕЗОНАМ";
            this.buttonForSeasons.UseVisualStyleBackColor = true;
            this.buttonForSeasons.Click += new System.EventHandler(this.buttonForSeasons_Click);
            // 
            // comboBoxForAnimal
            // 
            this.comboBoxForAnimal.DataSource = this.animalBindingSource;
            this.comboBoxForAnimal.DisplayMember = "Animal_name";
            this.comboBoxForAnimal.FormattingEnabled = true;
            this.comboBoxForAnimal.Location = new System.Drawing.Point(467, 168);
            this.comboBoxForAnimal.Name = "comboBoxForAnimal";
            this.comboBoxForAnimal.Size = new System.Drawing.Size(91, 21);
            this.comboBoxForAnimal.TabIndex = 2;
            this.comboBoxForAnimal.ValueMember = "Animal_id";
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.zooDataSet;
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxForFirstFeed
            // 
            this.comboBoxForFirstFeed.DataSource = this.feedBindingSource;
            this.comboBoxForFirstFeed.DisplayMember = "Name_of_feed";
            this.comboBoxForFirstFeed.FormattingEnabled = true;
            this.comboBoxForFirstFeed.Location = new System.Drawing.Point(467, 212);
            this.comboBoxForFirstFeed.Name = "comboBoxForFirstFeed";
            this.comboBoxForFirstFeed.Size = new System.Drawing.Size(91, 21);
            this.comboBoxForFirstFeed.TabIndex = 3;
            this.comboBoxForFirstFeed.ValueMember = "Feed_id";
            // 
            // feedBindingSource
            // 
            this.feedBindingSource.DataMember = "Feed";
            this.feedBindingSource.DataSource = this.zooDataSet;
            // 
            // comboBoxForSecondFeed
            // 
            this.comboBoxForSecondFeed.DataSource = this.feedBindingSource1;
            this.comboBoxForSecondFeed.DisplayMember = "Name_of_feed";
            this.comboBoxForSecondFeed.FormattingEnabled = true;
            this.comboBoxForSecondFeed.Location = new System.Drawing.Point(467, 239);
            this.comboBoxForSecondFeed.Name = "comboBoxForSecondFeed";
            this.comboBoxForSecondFeed.Size = new System.Drawing.Size(91, 21);
            this.comboBoxForSecondFeed.TabIndex = 4;
            this.comboBoxForSecondFeed.ValueMember = "Feed_id";
            // 
            // feedBindingSource1
            // 
            this.feedBindingSource1.DataMember = "Feed";
            this.feedBindingSource1.DataSource = this.zooDataSet;
            // 
            // comboBoxForThirdFeed
            // 
            this.comboBoxForThirdFeed.DataSource = this.feedBindingSource2;
            this.comboBoxForThirdFeed.DisplayMember = "Name_of_feed";
            this.comboBoxForThirdFeed.FormattingEnabled = true;
            this.comboBoxForThirdFeed.Location = new System.Drawing.Point(467, 266);
            this.comboBoxForThirdFeed.Name = "comboBoxForThirdFeed";
            this.comboBoxForThirdFeed.Size = new System.Drawing.Size(91, 21);
            this.comboBoxForThirdFeed.TabIndex = 5;
            this.comboBoxForThirdFeed.ValueMember = "Feed_id";
            // 
            // feedBindingSource2
            // 
            this.feedBindingSource2.DataMember = "Feed";
            this.feedBindingSource2.DataSource = this.zooDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // feedTableAdapter
            // 
            this.feedTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(494, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(452, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Оберіть тварину";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(460, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Оберіть корми";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(570, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxForThirdFeed);
            this.Controls.Add(this.comboBoxForSecondFeed);
            this.Controls.Add(this.comboBoxForFirstFeed);
            this.Controls.Add(this.comboBoxForAnimal);
            this.Controls.Add(this.buttonForSeasons);
            this.Controls.Add(this.buttonForParcel);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForParcel;
        private System.Windows.Forms.Button buttonForSeasons;
        private System.Windows.Forms.ComboBox comboBoxForAnimal;
        private System.Windows.Forms.ComboBox comboBoxForFirstFeed;
        private System.Windows.Forms.ComboBox comboBoxForSecondFeed;
        private System.Windows.Forms.ComboBox comboBoxForThirdFeed;
        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private ZooDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource feedBindingSource;
        private ZooDataSetTableAdapters.FeedTableAdapter feedTableAdapter;
        private System.Windows.Forms.BindingSource feedBindingSource1;
        private System.Windows.Forms.BindingSource feedBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}