namespace ZooMenu.AdminForms
{
    partial class CreateAndEditFormForCage
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
            System.Windows.Forms.Label cage_idLabel;
            System.Windows.Forms.Label max_count_of_animalLabel;
            System.Windows.Forms.Label group_of_animal_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAndEditFormForCage));
            this.zooDataSet = new ZooMenu.ZooDataSet();
            this.cageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cageTableAdapter = new ZooMenu.ZooDataSetTableAdapters.CageTableAdapter();
            this.tableAdapterManager = new ZooMenu.ZooDataSetTableAdapters.TableAdapterManager();
            this.groupOfAnimalTableAdapter = new ZooMenu.ZooDataSetTableAdapters.GroupOfAnimalTableAdapter();
            this.cage_idTextBox = new System.Windows.Forms.TextBox();
            this.max_count_of_animalTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupOfAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            cage_idLabel = new System.Windows.Forms.Label();
            max_count_of_animalLabel = new System.Windows.Forms.Label();
            group_of_animal_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cage_idLabel
            // 
            cage_idLabel.AutoSize = true;
            cage_idLabel.Location = new System.Drawing.Point(45, 71);
            cage_idLabel.Name = "cage_idLabel";
            cage_idLabel.Size = new System.Drawing.Size(46, 13);
            cage_idLabel.TabIndex = 1;
            cage_idLabel.Text = "Cage id:";
            // 
            // max_count_of_animalLabel
            // 
            max_count_of_animalLabel.AutoSize = true;
            max_count_of_animalLabel.Location = new System.Drawing.Point(45, 97);
            max_count_of_animalLabel.Name = "max_count_of_animalLabel";
            max_count_of_animalLabel.Size = new System.Drawing.Size(105, 13);
            max_count_of_animalLabel.TabIndex = 3;
            max_count_of_animalLabel.Text = "Max count of animal:";
            // 
            // group_of_animal_idLabel
            // 
            group_of_animal_idLabel.AutoSize = true;
            group_of_animal_idLabel.Location = new System.Drawing.Point(45, 123);
            group_of_animal_idLabel.Name = "group_of_animal_idLabel";
            group_of_animal_idLabel.Size = new System.Drawing.Size(95, 13);
            group_of_animal_idLabel.TabIndex = 5;
            group_of_animal_idLabel.Text = "Group of animal id:";
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cageBindingSource
            // 
            this.cageBindingSource.DataMember = "Cage";
            this.cageBindingSource.DataSource = this.zooDataSet;
            // 
            // cageTableAdapter
            // 
            this.cageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = this.cageTableAdapter;
            this.tableAdapterManager.FeedingTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = null;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = this.groupOfAnimalTableAdapter;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.ParcelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooMenu.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupOfAnimalTableAdapter
            // 
            this.groupOfAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // cage_idTextBox
            // 
            this.cage_idTextBox.Location = new System.Drawing.Point(156, 68);
            this.cage_idTextBox.Name = "cage_idTextBox";
            this.cage_idTextBox.ReadOnly = true;
            this.cage_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.cage_idTextBox.TabIndex = 2;
            // 
            // max_count_of_animalTextBox
            // 
            this.max_count_of_animalTextBox.Location = new System.Drawing.Point(156, 94);
            this.max_count_of_animalTextBox.Name = "max_count_of_animalTextBox";
            this.max_count_of_animalTextBox.Size = new System.Drawing.Size(100, 20);
            this.max_count_of_animalTextBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.groupOfAnimalBindingSource;
            this.comboBox1.DisplayMember = "Name_of_group";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Group_of_animal_id";
            // 
            // groupOfAnimalBindingSource
            // 
            this.groupOfAnimalBindingSource.DataMember = "GroupOfAnimal";
            this.groupOfAnimalBindingSource.DataSource = this.zooDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(48, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(267, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CreateAndEditFormForCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(343, 264);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(cage_idLabel);
            this.Controls.Add(this.cage_idTextBox);
            this.Controls.Add(max_count_of_animalLabel);
            this.Controls.Add(this.max_count_of_animalTextBox);
            this.Controls.Add(group_of_animal_idLabel);
            this.Name = "CreateAndEditFormForCage";
            this.Text = "CreateAndEditFormForCage";
            this.Load += new System.EventHandler(this.CreateAndEditFormForCage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource cageBindingSource;
        private ZooDataSetTableAdapters.CageTableAdapter cageTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cage_idTextBox;
        private System.Windows.Forms.TextBox max_count_of_animalTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private ZooDataSetTableAdapters.GroupOfAnimalTableAdapter groupOfAnimalTableAdapter;
        private System.Windows.Forms.BindingSource groupOfAnimalBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}