namespace CourseProject
{
    partial class CreateRecomendationsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.illnessComboBox = new System.Windows.Forms.ComboBox();
            this.illnessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinalPlantAphotecaryDataSet = new CourseProject.MedicinalPlantAphotecaryDataSet();
            this.illnessTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.IllnessTableAdapter();
            this.printButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printersList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.illnessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(-142, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 37);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Рекомендації, щодо лікування хвороби";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Оберіть хворобу:";
            // 
            // illnessComboBox
            // 
            this.illnessComboBox.DataSource = this.illnessBindingSource;
            this.illnessComboBox.DisplayMember = "Illness_Name";
            this.illnessComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illnessComboBox.FormattingEnabled = true;
            this.illnessComboBox.Location = new System.Drawing.Point(124, 175);
            this.illnessComboBox.Name = "illnessComboBox";
            this.illnessComboBox.Size = new System.Drawing.Size(364, 37);
            this.illnessComboBox.TabIndex = 12;
            this.illnessComboBox.ValueMember = "Illness_Id";
            // 
            // illnessBindingSource
            // 
            this.illnessBindingSource.DataMember = "Illness";
            this.illnessBindingSource.DataSource = this.medicinalPlantAphotecaryDataSet;
            // 
            // medicinalPlantAphotecaryDataSet
            // 
            this.medicinalPlantAphotecaryDataSet.DataSetName = "MedicinalPlantAphotecaryDataSet";
            this.medicinalPlantAphotecaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // illnessTableAdapter
            // 
            this.illnessTableAdapter.ClearBeforeFill = true;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(180, 348);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(272, 70);
            this.printButton.TabIndex = 13;
            this.printButton.Text = "Роздрукувати рекомендації";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Оберіть принтер:";
            // 
            // printersList
            // 
            this.printersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printersList.FormattingEnabled = true;
            this.printersList.Location = new System.Drawing.Point(180, 277);
            this.printersList.Name = "printersList";
            this.printersList.Size = new System.Drawing.Size(263, 32);
            this.printersList.TabIndex = 31;
            // 
            // GetRecomendationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.printersList);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.illnessComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "GetRecomendationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetRecomendationsForm";
            this.Load += new System.EventHandler(this.GetRecomendationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.illnessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox illnessComboBox;
        private MedicinalPlantAphotecaryDataSet medicinalPlantAphotecaryDataSet;
        private System.Windows.Forms.BindingSource illnessBindingSource;
        private MedicinalPlantAphotecaryDataSetTableAdapters.IllnessTableAdapter illnessTableAdapter;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox printersList;
    }
}