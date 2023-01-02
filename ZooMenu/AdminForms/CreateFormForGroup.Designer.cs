namespace ZooMenu.AdminForms
{
    partial class CreateFormForGroup
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
            System.Windows.Forms.Label group_of_animal_idLabel;
            System.Windows.Forms.Label name_of_groupLabel;
            System.Windows.Forms.Label food_methodLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFormForGroup));
            this.zooDataSet = new ZooMenu.ZooDataSet();
            this.groupOfAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupOfAnimalTableAdapter = new ZooMenu.ZooDataSetTableAdapters.GroupOfAnimalTableAdapter();
            this.tableAdapterManager = new ZooMenu.ZooDataSetTableAdapters.TableAdapterManager();
            this.group_of_animal_idTextBox = new System.Windows.Forms.TextBox();
            this.name_of_groupTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            group_of_animal_idLabel = new System.Windows.Forms.Label();
            name_of_groupLabel = new System.Windows.Forms.Label();
            food_methodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // group_of_animal_idLabel
            // 
            group_of_animal_idLabel.AutoSize = true;
            group_of_animal_idLabel.Location = new System.Drawing.Point(16, 53);
            group_of_animal_idLabel.Name = "group_of_animal_idLabel";
            group_of_animal_idLabel.Size = new System.Drawing.Size(95, 13);
            group_of_animal_idLabel.TabIndex = 1;
            group_of_animal_idLabel.Text = "Group of animal id:";
            // 
            // name_of_groupLabel
            // 
            name_of_groupLabel.AutoSize = true;
            name_of_groupLabel.Location = new System.Drawing.Point(16, 79);
            name_of_groupLabel.Name = "name_of_groupLabel";
            name_of_groupLabel.Size = new System.Drawing.Size(80, 13);
            name_of_groupLabel.TabIndex = 3;
            name_of_groupLabel.Text = "Name of group:";
            // 
            // food_methodLabel
            // 
            food_methodLabel.AutoSize = true;
            food_methodLabel.Location = new System.Drawing.Point(16, 105);
            food_methodLabel.Name = "food_methodLabel";
            food_methodLabel.Size = new System.Drawing.Size(72, 13);
            food_methodLabel.TabIndex = 5;
            food_methodLabel.Text = "Food method:";
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupOfAnimalBindingSource
            // 
            this.groupOfAnimalBindingSource.DataMember = "GroupOfAnimal";
            this.groupOfAnimalBindingSource.DataSource = this.zooDataSet;
            // 
            // groupOfAnimalTableAdapter
            // 
            this.groupOfAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = null;
            this.tableAdapterManager.FeedingTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = null;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = this.groupOfAnimalTableAdapter;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.ParcelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooMenu.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // group_of_animal_idTextBox
            // 
            this.group_of_animal_idTextBox.Location = new System.Drawing.Point(117, 46);
            this.group_of_animal_idTextBox.Name = "group_of_animal_idTextBox";
            this.group_of_animal_idTextBox.ReadOnly = true;
            this.group_of_animal_idTextBox.Size = new System.Drawing.Size(114, 20);
            this.group_of_animal_idTextBox.TabIndex = 2;
            // 
            // name_of_groupTextBox
            // 
            this.name_of_groupTextBox.Location = new System.Drawing.Point(117, 76);
            this.name_of_groupTextBox.Name = "name_of_groupTextBox";
            this.name_of_groupTextBox.Size = new System.Drawing.Size(114, 20);
            this.name_of_groupTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Group of animal";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "М`ясоїд",
            "Травоїд"});
            this.comboBox1.Location = new System.Drawing.Point(117, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CreateFormForGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(300, 236);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(group_of_animal_idLabel);
            this.Controls.Add(this.group_of_animal_idTextBox);
            this.Controls.Add(name_of_groupLabel);
            this.Controls.Add(this.name_of_groupTextBox);
            this.Controls.Add(food_methodLabel);
            this.Name = "CreateFormForGroup";
            this.Text = "CreateFormForGroup";
            this.Load += new System.EventHandler(this.CreateFormForGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource groupOfAnimalBindingSource;
        private ZooDataSetTableAdapters.GroupOfAnimalTableAdapter groupOfAnimalTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox group_of_animal_idTextBox;
        private System.Windows.Forms.TextBox name_of_groupTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}