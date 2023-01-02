namespace ZooMenu.AdminForms
{
    partial class CreateAndEditFormForFeed
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
            System.Windows.Forms.Label feed_idLabel;
            System.Windows.Forms.Label caloricLabel;
            System.Windows.Forms.Label name_of_feedLabel;
            System.Windows.Forms.Label parcel_idLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAndEditFormForFeed));
            this.feed_idTextBox = new System.Windows.Forms.TextBox();
            this.caloricTextBox = new System.Windows.Forms.TextBox();
            this.name_of_feedTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.zooDataSet = new ZooMenu.ZooDataSet();
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedTableAdapter = new ZooMenu.ZooDataSetTableAdapters.FeedTableAdapter();
            this.tableAdapterManager = new ZooMenu.ZooDataSetTableAdapters.TableAdapterManager();
            this.parcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxParcel = new System.Windows.Forms.ComboBox();
            this.parcelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxKindOfFood = new System.Windows.Forms.ComboBox();
            this.parcelTableAdapter = new ZooMenu.ZooDataSetTableAdapters.ParcelTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            feed_idLabel = new System.Windows.Forms.Label();
            caloricLabel = new System.Windows.Forms.Label();
            name_of_feedLabel = new System.Windows.Forms.Label();
            parcel_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // feed_idLabel
            // 
            feed_idLabel.AutoSize = true;
            feed_idLabel.Location = new System.Drawing.Point(26, 115);
            feed_idLabel.Name = "feed_idLabel";
            feed_idLabel.Size = new System.Drawing.Size(45, 13);
            feed_idLabel.TabIndex = 0;
            feed_idLabel.Text = "Feed id:";
            // 
            // caloricLabel
            // 
            caloricLabel.AutoSize = true;
            caloricLabel.Location = new System.Drawing.Point(26, 141);
            caloricLabel.Name = "caloricLabel";
            caloricLabel.Size = new System.Drawing.Size(42, 13);
            caloricLabel.TabIndex = 2;
            caloricLabel.Text = "Caloric:";
            // 
            // name_of_feedLabel
            // 
            name_of_feedLabel.AutoSize = true;
            name_of_feedLabel.Location = new System.Drawing.Point(26, 173);
            name_of_feedLabel.Name = "name_of_feedLabel";
            name_of_feedLabel.Size = new System.Drawing.Size(74, 13);
            name_of_feedLabel.TabIndex = 10;
            name_of_feedLabel.Text = "Name of feed:";
            // 
            // parcel_idLabel
            // 
            parcel_idLabel.AutoSize = true;
            parcel_idLabel.Location = new System.Drawing.Point(26, 199);
            parcel_idLabel.Name = "parcel_idLabel";
            parcel_idLabel.Size = new System.Drawing.Size(51, 13);
            parcel_idLabel.TabIndex = 12;
            parcel_idLabel.Text = "Parcel id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 229);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 13);
            label1.TabIndex = 15;
            label1.Text = "Kind o food:";
            // 
            // feed_idTextBox
            // 
            this.feed_idTextBox.Location = new System.Drawing.Point(165, 112);
            this.feed_idTextBox.Name = "feed_idTextBox";
            this.feed_idTextBox.ReadOnly = true;
            this.feed_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.feed_idTextBox.TabIndex = 1;
            // 
            // caloricTextBox
            // 
            this.caloricTextBox.Location = new System.Drawing.Point(165, 138);
            this.caloricTextBox.Name = "caloricTextBox";
            this.caloricTextBox.Size = new System.Drawing.Size(100, 20);
            this.caloricTextBox.TabIndex = 3;
            // 
            // name_of_feedTextBox
            // 
            this.name_of_feedTextBox.Location = new System.Drawing.Point(165, 170);
            this.name_of_feedTextBox.Name = "name_of_feedTextBox";
            this.name_of_feedTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_of_feedTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(29, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "ЗБЕРЕГТИ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBindingSource
            // 
            this.feedBindingSource.DataMember = "Feed";
            this.feedBindingSource.DataSource = this.zooDataSet;
            // 
            // feedTableAdapter
            // 
            this.feedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = null;
            this.tableAdapterManager.FeedingTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = this.feedTableAdapter;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.ParcelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooMenu.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // parcelBindingSource
            // 
            this.parcelBindingSource.DataMember = "Parcel";
            this.parcelBindingSource.DataSource = this.zooDataSet;
            // 
            // comboBoxParcel
            // 
            this.comboBoxParcel.DataSource = this.parcelBindingSource1;
            this.comboBoxParcel.DisplayMember = "Feed_name";
            this.comboBoxParcel.FormattingEnabled = true;
            this.comboBoxParcel.Location = new System.Drawing.Point(165, 199);
            this.comboBoxParcel.Name = "comboBoxParcel";
            this.comboBoxParcel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxParcel.TabIndex = 16;
            this.comboBoxParcel.ValueMember = "Parcel_id";
            // 
            // parcelBindingSource1
            // 
            this.parcelBindingSource1.DataMember = "Parcel";
            this.parcelBindingSource1.DataSource = this.zooDataSet;
            // 
            // comboBoxKindOfFood
            // 
            this.comboBoxKindOfFood.FormattingEnabled = true;
            this.comboBoxKindOfFood.Items.AddRange(new object[] {
            "М`ясоїд",
            "Травоїд"});
            this.comboBoxKindOfFood.Location = new System.Drawing.Point(165, 229);
            this.comboBoxKindOfFood.Name = "comboBoxKindOfFood";
            this.comboBoxKindOfFood.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKindOfFood.TabIndex = 17;
            // 
            // parcelTableAdapter
            // 
            this.parcelTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(118, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Feed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-222, -237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 316);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(349, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // CreateAndEditFormForFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(425, 381);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKindOfFood);
            this.Controls.Add(this.comboBoxParcel);
            this.Controls.Add(label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(feed_idLabel);
            this.Controls.Add(this.feed_idTextBox);
            this.Controls.Add(caloricLabel);
            this.Controls.Add(this.caloricTextBox);
            this.Controls.Add(name_of_feedLabel);
            this.Controls.Add(this.name_of_feedTextBox);
            this.Controls.Add(parcel_idLabel);
            this.Name = "CreateAndEditFormForFeed";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CreateAndEditFormForFeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource feedBindingSource;
        private ZooDataSetTableAdapters.FeedTableAdapter feedTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource parcelBindingSource;
        private System.Windows.Forms.TextBox feed_idTextBox;
        private System.Windows.Forms.TextBox caloricTextBox;
        private System.Windows.Forms.TextBox name_of_feedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxParcel;
        private System.Windows.Forms.ComboBox comboBoxKindOfFood;
        private System.Windows.Forms.BindingSource parcelBindingSource1;
        private ZooDataSetTableAdapters.ParcelTableAdapter parcelTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}