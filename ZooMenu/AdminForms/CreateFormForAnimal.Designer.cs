namespace ZooMenu.AdminForms
{
    partial class CreateFormForAnimal
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
            System.Windows.Forms.Label animal_idLabel;
            System.Windows.Forms.Label animal_nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label weight_of_animalLabel;
            System.Windows.Forms.Label date_addLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label group_of_animal_idLabel;
            System.Windows.Forms.Label cage_idLabel;
            System.Windows.Forms.Label Helth;
            System.Windows.Forms.Label calories_per_dayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFormForAnimal));
            this.animal_idTextBox = new System.Windows.Forms.TextBox();
            this.animal_nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.weight_of_animalTextBox = new System.Windows.Forms.TextBox();
            this.date_addDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.group_of_animal_idCombo = new System.Windows.Forms.ComboBox();
            this.groupOfAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zooDataSet1 = new ZooMenu.ZooDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zooDataSet3 = new ZooMenu.ZooDataSet();
            this.zooDataSet = new ZooMenu.ZooDataSet();
            this.groupOfAnimalTableAdapter = new ZooMenu.ZooDataSetTableAdapters.GroupOfAnimalTableAdapter();
            this.zooDataSet2 = new ZooMenu.ZooDataSet();
            this.tableAdapterManager = new ZooMenu.ZooDataSetTableAdapters.TableAdapterManager();
            this.cageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cageTableAdapter = new ZooMenu.ZooDataSetTableAdapters.CageTableAdapter();
            this.comboBoxHealth = new System.Windows.Forms.ComboBox();
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new ZooMenu.ZooDataSetTableAdapters.AnimalTableAdapter();
            this.zooDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.calories_per_dayTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            animal_idLabel = new System.Windows.Forms.Label();
            animal_nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            weight_of_animalLabel = new System.Windows.Forms.Label();
            date_addLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            group_of_animal_idLabel = new System.Windows.Forms.Label();
            cage_idLabel = new System.Windows.Forms.Label();
            Helth = new System.Windows.Forms.Label();
            calories_per_dayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // animal_idLabel
            // 
            animal_idLabel.AutoSize = true;
            animal_idLabel.Location = new System.Drawing.Point(12, 59);
            animal_idLabel.Name = "animal_idLabel";
            animal_idLabel.Size = new System.Drawing.Size(52, 13);
            animal_idLabel.TabIndex = 3;
            animal_idLabel.Text = "Animal id:";
            // 
            // animal_nameLabel
            // 
            animal_nameLabel.AutoSize = true;
            animal_nameLabel.Location = new System.Drawing.Point(12, 85);
            animal_nameLabel.Name = "animal_nameLabel";
            animal_nameLabel.Size = new System.Drawing.Size(70, 13);
            animal_nameLabel.TabIndex = 5;
            animal_nameLabel.Text = "Animal name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(12, 111);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "Age:";
            // 
            // weight_of_animalLabel
            // 
            weight_of_animalLabel.AutoSize = true;
            weight_of_animalLabel.Location = new System.Drawing.Point(12, 137);
            weight_of_animalLabel.Name = "weight_of_animalLabel";
            weight_of_animalLabel.Size = new System.Drawing.Size(89, 13);
            weight_of_animalLabel.TabIndex = 9;
            weight_of_animalLabel.Text = "Weight of animal:";
            // 
            // date_addLabel
            // 
            date_addLabel.AutoSize = true;
            date_addLabel.Location = new System.Drawing.Point(12, 164);
            date_addLabel.Name = "date_addLabel";
            date_addLabel.Size = new System.Drawing.Size(54, 13);
            date_addLabel.TabIndex = 11;
            date_addLabel.Text = "Date add:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(12, 189);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 13;
            sexLabel.Text = "Sex:";
            // 
            // group_of_animal_idLabel
            // 
            group_of_animal_idLabel.AutoSize = true;
            group_of_animal_idLabel.Location = new System.Drawing.Point(12, 215);
            group_of_animal_idLabel.Name = "group_of_animal_idLabel";
            group_of_animal_idLabel.Size = new System.Drawing.Size(95, 13);
            group_of_animal_idLabel.TabIndex = 15;
            group_of_animal_idLabel.Text = "Group of animal id:";
            // 
            // cage_idLabel
            // 
            cage_idLabel.AutoSize = true;
            cage_idLabel.Location = new System.Drawing.Point(12, 241);
            cage_idLabel.Name = "cage_idLabel";
            cage_idLabel.Size = new System.Drawing.Size(46, 13);
            cage_idLabel.TabIndex = 17;
            cage_idLabel.Text = "Cage id:";
            // 
            // Helth
            // 
            Helth.AutoSize = true;
            Helth.Location = new System.Drawing.Point(12, 307);
            Helth.Name = "Helth";
            Helth.Size = new System.Drawing.Size(38, 13);
            Helth.TabIndex = 32;
            Helth.Text = "Health";
            // 
            // calories_per_dayLabel
            // 
            calories_per_dayLabel.AutoSize = true;
            calories_per_dayLabel.Location = new System.Drawing.Point(12, 267);
            calories_per_dayLabel.Name = "calories_per_dayLabel";
            calories_per_dayLabel.Size = new System.Drawing.Size(85, 13);
            calories_per_dayLabel.TabIndex = 19;
            calories_per_dayLabel.Text = "Calories per day:";
            // 
            // animal_idTextBox
            // 
            this.animal_idTextBox.Location = new System.Drawing.Point(150, 56);
            this.animal_idTextBox.Name = "animal_idTextBox";
            this.animal_idTextBox.ReadOnly = true;
            this.animal_idTextBox.Size = new System.Drawing.Size(231, 20);
            this.animal_idTextBox.TabIndex = 4;
            // 
            // animal_nameTextBox
            // 
            this.animal_nameTextBox.Location = new System.Drawing.Point(150, 82);
            this.animal_nameTextBox.Name = "animal_nameTextBox";
            this.animal_nameTextBox.Size = new System.Drawing.Size(231, 20);
            this.animal_nameTextBox.TabIndex = 6;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(150, 108);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(231, 20);
            this.ageTextBox.TabIndex = 8;
            // 
            // weight_of_animalTextBox
            // 
            this.weight_of_animalTextBox.Location = new System.Drawing.Point(150, 134);
            this.weight_of_animalTextBox.Name = "weight_of_animalTextBox";
            this.weight_of_animalTextBox.Size = new System.Drawing.Size(231, 20);
            this.weight_of_animalTextBox.TabIndex = 10;
            // 
            // date_addDateTimePicker
            // 
            this.date_addDateTimePicker.Location = new System.Drawing.Point(150, 160);
            this.date_addDateTimePicker.Name = "date_addDateTimePicker";
            this.date_addDateTimePicker.Size = new System.Drawing.Size(231, 20);
            this.date_addDateTimePicker.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Animal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(42, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 60);
            this.button1.TabIndex = 28;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // group_of_animal_idCombo
            // 
            this.group_of_animal_idCombo.DataSource = this.groupOfAnimalBindingSource;
            this.group_of_animal_idCombo.DisplayMember = "Name_of_group";
            this.group_of_animal_idCombo.FormattingEnabled = true;
            this.group_of_animal_idCombo.Location = new System.Drawing.Point(150, 212);
            this.group_of_animal_idCombo.Name = "group_of_animal_idCombo";
            this.group_of_animal_idCombo.Size = new System.Drawing.Size(231, 21);
            this.group_of_animal_idCombo.TabIndex = 29;
            this.group_of_animal_idCombo.ValueMember = "Group_of_animal_id";
            this.group_of_animal_idCombo.SelectedIndexChanged += new System.EventHandler(this.group_of_animal_idCombo_SelectedIndexChanged);
            // 
            // groupOfAnimalBindingSource
            // 
            this.groupOfAnimalBindingSource.DataMember = "GroupOfAnimal";
            this.groupOfAnimalBindingSource.DataSource = this.zooDataSet1;
            // 
            // zooDataSet1
            // 
            this.zooDataSet1.DataSetName = "ZooDataSet";
            this.zooDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cageBindingSource1
            // 
            this.cageBindingSource1.DataMember = "Cage";
            this.cageBindingSource1.DataSource = this.zooDataSet3;
            // 
            // zooDataSet3
            // 
            this.zooDataSet3.DataSetName = "ZooDataSet";
            this.zooDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupOfAnimalTableAdapter
            // 
            this.groupOfAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // zooDataSet2
            // 
            this.zooDataSet2.DataSetName = "ZooDataSet";
            this.zooDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cageBindingSource
            // 
            this.cageBindingSource.DataMember = "Cage";
            this.cageBindingSource.DataSource = this.zooDataSet2;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.zooDataSet;
            // 
            // cageTableAdapter
            // 
            this.cageTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxHealth
            // 
            this.comboBoxHealth.FormattingEnabled = true;
            this.comboBoxHealth.Items.AddRange(new object[] {
            "Здорова",
            "Хвора"});
            this.comboBoxHealth.Location = new System.Drawing.Point(150, 304);
            this.comboBoxHealth.Name = "comboBoxHealth";
            this.comboBoxHealth.Size = new System.Drawing.Size(231, 21);
            this.comboBoxHealth.TabIndex = 31;
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataMember = "Animal";
            this.animalBindingSource1.DataSource = this.zooDataSet1;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // zooDataSet1BindingSource
            // 
            this.zooDataSet1BindingSource.DataSource = this.zooDataSet1;
            this.zooDataSet1BindingSource.Position = 0;
            // 
            // cageBindingSource2
            // 
            this.cageBindingSource2.DataMember = "Cage";
            this.cageBindingSource2.DataSource = this.zooDataSet1BindingSource;
            // 
            // calories_per_dayTextBox
            // 
            this.calories_per_dayTextBox.Location = new System.Drawing.Point(150, 264);
            this.calories_per_dayTextBox.Name = "calories_per_dayTextBox";
            this.calories_per_dayTextBox.Size = new System.Drawing.Size(231, 20);
            this.calories_per_dayTextBox.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.comboBox2.Location = new System.Drawing.Point(150, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 21);
            this.comboBox2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-221, -298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-36, 433);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(319, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(492, 322);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(457, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // CreateFormForAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(533, 511);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(Helth);
            this.Controls.Add(this.comboBoxHealth);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.group_of_animal_idCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(animal_idLabel);
            this.Controls.Add(this.animal_idTextBox);
            this.Controls.Add(animal_nameLabel);
            this.Controls.Add(this.animal_nameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(weight_of_animalLabel);
            this.Controls.Add(this.weight_of_animalTextBox);
            this.Controls.Add(date_addLabel);
            this.Controls.Add(this.date_addDateTimePicker);
            this.Controls.Add(sexLabel);
            this.Controls.Add(group_of_animal_idLabel);
            this.Controls.Add(cage_idLabel);
            this.Controls.Add(calories_per_dayLabel);
            this.Controls.Add(this.calories_per_dayTextBox);
            this.Name = "CreateFormForAnimal";
            this.Text = "CreateForm";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox animal_idTextBox;
        private System.Windows.Forms.TextBox animal_nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox weight_of_animalTextBox;
        private System.Windows.Forms.DateTimePicker date_addDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox group_of_animal_idCombo;
        private ZooDataSet zooDataSet1;
        private System.Windows.Forms.BindingSource groupOfAnimalBindingSource;
        private ZooDataSetTableAdapters.GroupOfAnimalTableAdapter groupOfAnimalTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private ZooDataSet zooDataSet2;
        private System.Windows.Forms.BindingSource cageBindingSource;
        private ZooDataSet zooDataSet3;
        private System.Windows.Forms.BindingSource cageBindingSource1;
        private ZooDataSetTableAdapters.CageTableAdapter cageTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxHealth;
        private System.Windows.Forms.BindingSource animalBindingSource1;
        private ZooDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource cageBindingSource2;
        private System.Windows.Forms.BindingSource zooDataSet1BindingSource;
        private System.Windows.Forms.TextBox calories_per_dayTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}