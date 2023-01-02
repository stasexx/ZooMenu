namespace ZooMenu.AdminForms
{
    partial class CreateAndEditFormForParcel
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
            System.Windows.Forms.Label parcel_idLabel;
            System.Windows.Forms.Label feed_nameLabel;
            System.Windows.Forms.Label date_of_receiptLabel;
            System.Windows.Forms.Label date_of_overdueLabel;
            System.Windows.Forms.Label count_of_feedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAndEditFormForParcel));
            this.zooDataSet = new ZooMenu.ZooDataSet();
            this.parcel_idTextBox = new System.Windows.Forms.TextBox();
            this.feed_nameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_receiptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_of_overdueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.count_of_feedTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new ZooMenu.ZooDataSetTableAdapters.TableAdapterManager();
            this.parcelTableAdapter = new ZooMenu.ZooDataSetTableAdapters.ParcelTableAdapter();
            this.parcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            parcel_idLabel = new System.Windows.Forms.Label();
            feed_nameLabel = new System.Windows.Forms.Label();
            date_of_receiptLabel = new System.Windows.Forms.Label();
            date_of_overdueLabel = new System.Windows.Forms.Label();
            count_of_feedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // parcel_idLabel
            // 
            parcel_idLabel.AutoSize = true;
            parcel_idLabel.Location = new System.Drawing.Point(25, 149);
            parcel_idLabel.Name = "parcel_idLabel";
            parcel_idLabel.Size = new System.Drawing.Size(51, 13);
            parcel_idLabel.TabIndex = 1;
            parcel_idLabel.Text = "Parcel id:";
            // 
            // feed_nameLabel
            // 
            feed_nameLabel.AutoSize = true;
            feed_nameLabel.Location = new System.Drawing.Point(25, 175);
            feed_nameLabel.Name = "feed_nameLabel";
            feed_nameLabel.Size = new System.Drawing.Size(63, 13);
            feed_nameLabel.TabIndex = 3;
            feed_nameLabel.Text = "Feed name:";
            // 
            // date_of_receiptLabel
            // 
            date_of_receiptLabel.AutoSize = true;
            date_of_receiptLabel.Location = new System.Drawing.Point(25, 202);
            date_of_receiptLabel.Name = "date_of_receiptLabel";
            date_of_receiptLabel.Size = new System.Drawing.Size(80, 13);
            date_of_receiptLabel.TabIndex = 5;
            date_of_receiptLabel.Text = "Date of receipt:";
            // 
            // date_of_overdueLabel
            // 
            date_of_overdueLabel.AutoSize = true;
            date_of_overdueLabel.Location = new System.Drawing.Point(25, 228);
            date_of_overdueLabel.Name = "date_of_overdueLabel";
            date_of_overdueLabel.Size = new System.Drawing.Size(87, 13);
            date_of_overdueLabel.TabIndex = 7;
            date_of_overdueLabel.Text = "Date of overdue:";
            // 
            // count_of_feedLabel
            // 
            count_of_feedLabel.AutoSize = true;
            count_of_feedLabel.Location = new System.Drawing.Point(25, 253);
            count_of_feedLabel.Name = "count_of_feedLabel";
            count_of_feedLabel.Size = new System.Drawing.Size(74, 13);
            count_of_feedLabel.TabIndex = 9;
            count_of_feedLabel.Text = "Count of feed:";
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parcel_idTextBox
            // 
            this.parcel_idTextBox.Location = new System.Drawing.Point(118, 146);
            this.parcel_idTextBox.Name = "parcel_idTextBox";
            this.parcel_idTextBox.ReadOnly = true;
            this.parcel_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.parcel_idTextBox.TabIndex = 2;
            // 
            // feed_nameTextBox
            // 
            this.feed_nameTextBox.Location = new System.Drawing.Point(118, 172);
            this.feed_nameTextBox.Name = "feed_nameTextBox";
            this.feed_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.feed_nameTextBox.TabIndex = 4;
            // 
            // date_of_receiptDateTimePicker
            // 
            this.date_of_receiptDateTimePicker.Location = new System.Drawing.Point(118, 198);
            this.date_of_receiptDateTimePicker.Name = "date_of_receiptDateTimePicker";
            this.date_of_receiptDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_receiptDateTimePicker.TabIndex = 6;
            // 
            // date_of_overdueDateTimePicker
            // 
            this.date_of_overdueDateTimePicker.Location = new System.Drawing.Point(118, 224);
            this.date_of_overdueDateTimePicker.Name = "date_of_overdueDateTimePicker";
            this.date_of_overdueDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_overdueDateTimePicker.TabIndex = 8;
            // 
            // count_of_feedTextBox
            // 
            this.count_of_feedTextBox.Location = new System.Drawing.Point(118, 250);
            this.count_of_feedTextBox.Name = "count_of_feedTextBox";
            this.count_of_feedTextBox.Size = new System.Drawing.Size(200, 20);
            this.count_of_feedTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "ЗБЕРЕГТИ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FeedingTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = null;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.ParcelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooMenu.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // parcelTableAdapter
            // 
            this.parcelTableAdapter.ClearBeforeFill = true;
            // 
            // parcelBindingSource
            // 
            this.parcelBindingSource.DataMember = "Parcel";
            this.parcelBindingSource.DataSource = this.zooDataSet;
            // 
            // feedBindingSource
            // 
            this.feedBindingSource.DataMember = "Feed";
            this.feedBindingSource.DataSource = this.zooDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Parcel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-113, -98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-18, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(311, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 197);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(325, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // CreateAndEditFormForParcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(401, 442);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(parcel_idLabel);
            this.Controls.Add(this.parcel_idTextBox);
            this.Controls.Add(feed_nameLabel);
            this.Controls.Add(this.feed_nameTextBox);
            this.Controls.Add(date_of_receiptLabel);
            this.Controls.Add(this.date_of_receiptDateTimePicker);
            this.Controls.Add(date_of_overdueLabel);
            this.Controls.Add(this.date_of_overdueDateTimePicker);
            this.Controls.Add(count_of_feedLabel);
            this.Controls.Add(this.count_of_feedTextBox);
            this.Name = "CreateAndEditFormForParcel";
            this.Text = "CreateAndEditFormForParcel";
            this.Load += new System.EventHandler(this.CreateAndEditFormForParcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource parcelBindingSource;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox parcel_idTextBox;
        private System.Windows.Forms.TextBox feed_nameTextBox;
        private System.Windows.Forms.DateTimePicker date_of_receiptDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_of_overdueDateTimePicker;
        private System.Windows.Forms.TextBox count_of_feedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource feedBindingSource;
        private ZooDataSetTableAdapters.ParcelTableAdapter parcelTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}