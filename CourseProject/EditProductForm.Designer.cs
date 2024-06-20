namespace CourseProject
{
    partial class EditProductForm
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
            this.contraindicationsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.methodOfApplicationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinalPlantAphotecaryDataSet = new CourseProject.MedicinalPlantAphotecaryDataSet();
            this.brandTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.BrandTableAdapter();
            this.medicinal_PlantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinal_PlantTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.Medicinal_PlantTableAdapter();
            this.tableAdapterManager = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager();
            this.illnessTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.IllnessTableAdapter();
            this.productTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.ProductTableAdapter();
            this.plantDataGridView = new System.Windows.Forms.DataGridView();
            this.addedPlantDataGridView = new System.Windows.Forms.DataGridView();
            this.illnessDataGridView = new System.Windows.Forms.DataGridView();
            this.addedIllnessDataGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addPlantButton = new System.Windows.Forms.Button();
            this.addIllnessButton = new System.Windows.Forms.Button();
            this.deletePlantButton = new System.Windows.Forms.Button();
            this.deleteIllnessButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinal_PlantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedPlantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illnessDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedIllnessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contraindicationsTextBox
            // 
            this.contraindicationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraindicationsTextBox.Location = new System.Drawing.Point(331, 226);
            this.contraindicationsTextBox.Name = "contraindicationsTextBox";
            this.contraindicationsTextBox.Size = new System.Drawing.Size(264, 31);
            this.contraindicationsTextBox.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 33);
            this.label6.TabIndex = 56;
            this.label6.Text = "Спосіб застосування";
            // 
            // methodOfApplicationTextBox
            // 
            this.methodOfApplicationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodOfApplicationTextBox.Location = new System.Drawing.Point(331, 369);
            this.methodOfApplicationTextBox.Name = "methodOfApplicationTextBox";
            this.methodOfApplicationTextBox.Size = new System.Drawing.Size(264, 31);
            this.methodOfApplicationTextBox.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 33);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ціна";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(331, 301);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(264, 31);
            this.priceTextBox.TabIndex = 53;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(744, 652);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 44);
            this.cancelButton.TabIndex = 52;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(468, 652);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(142, 44);
            this.okButton.TabIndex = 51;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 33);
            this.label4.TabIndex = 50;
            this.label4.Text = "Протипоказання";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 33);
            this.label3.TabIndex = 49;
            this.label3.Text = "Категорія";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 48;
            this.label2.Text = "Назва";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.Location = new System.Drawing.Point(331, 149);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(264, 31);
            this.categoryTextBox.TabIndex = 47;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(331, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(264, 31);
            this.nameTextBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 45;
            this.label1.Text = "Продукт";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(331, 438);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(264, 31);
            this.weightTextBox.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 33);
            this.label7.TabIndex = 62;
            this.label7.Text = "Бренд";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 33);
            this.label8.TabIndex = 60;
            this.label8.Text = "Кількість";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(331, 497);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(264, 31);
            this.quantityTextBox.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 33);
            this.label9.TabIndex = 58;
            this.label9.Text = "Вага";
            // 
            // brandComboBox
            // 
            this.brandComboBox.DataSource = this.brandBindingSource;
            this.brandComboBox.DisplayMember = "Brand_Name";
            this.brandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(331, 560);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(264, 32);
            this.brandComboBox.TabIndex = 64;
            this.brandComboBox.ValueMember = "Brand_Id";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.medicinalPlantAphotecaryDataSet;
            // 
            // medicinalPlantAphotecaryDataSet
            // 
            this.medicinalPlantAphotecaryDataSet.DataSetName = "MedicinalPlantAphotecaryDataSet";
            this.medicinalPlantAphotecaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // medicinal_PlantBindingSource
            // 
            this.medicinal_PlantBindingSource.DataMember = "Medicinal_Plant";
            this.medicinal_PlantBindingSource.DataSource = this.medicinalPlantAphotecaryDataSet;
            // 
            // medicinal_PlantTableAdapter
            // 
            this.medicinal_PlantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = this.brandTableAdapter;
            this.tableAdapterManager.Client_CardTableAdapter = null;
            this.tableAdapterManager.IllnessTableAdapter = this.illnessTableAdapter;
            this.tableAdapterManager.Medicinal_PlantTableAdapter = this.medicinal_PlantTableAdapter;
            this.tableAdapterManager.Plant_in_ProductTableAdapter = null;
            this.tableAdapterManager.Product_from_IllnessTableAdapter = null;
            this.tableAdapterManager.Product_QuantityTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // illnessTableAdapter
            // 
            this.illnessTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // plantDataGridView
            // 
            this.plantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plantDataGridView.Location = new System.Drawing.Point(744, 74);
            this.plantDataGridView.Name = "plantDataGridView";
            this.plantDataGridView.Size = new System.Drawing.Size(299, 106);
            this.plantDataGridView.TabIndex = 64;
            // 
            // addedPlantDataGridView
            // 
            this.addedPlantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedPlantDataGridView.Location = new System.Drawing.Point(744, 232);
            this.addedPlantDataGridView.Name = "addedPlantDataGridView";
            this.addedPlantDataGridView.Size = new System.Drawing.Size(299, 106);
            this.addedPlantDataGridView.TabIndex = 65;
            // 
            // illnessDataGridView
            // 
            this.illnessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.illnessDataGridView.Location = new System.Drawing.Point(744, 377);
            this.illnessDataGridView.Name = "illnessDataGridView";
            this.illnessDataGridView.Size = new System.Drawing.Size(299, 106);
            this.illnessDataGridView.TabIndex = 66;
            // 
            // addedIllnessDataGridView
            // 
            this.addedIllnessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedIllnessDataGridView.Location = new System.Drawing.Point(744, 522);
            this.addedIllnessDataGridView.Name = "addedIllnessDataGridView";
            this.addedIllnessDataGridView.Size = new System.Drawing.Size(299, 106);
            this.addedIllnessDataGridView.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(738, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 33);
            this.label10.TabIndex = 68;
            this.label10.Text = "Рослини у складі";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(738, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 33);
            this.label11.TabIndex = 69;
            this.label11.Text = "Рослини";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(738, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 33);
            this.label12.TabIndex = 70;
            this.label12.Text = "Хвороби";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(741, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(261, 33);
            this.label13.TabIndex = 71;
            this.label13.Text = "Хвороби, які лікує";
            // 
            // addPlantButton
            // 
            this.addPlantButton.BackColor = System.Drawing.Color.Honeydew;
            this.addPlantButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.addPlantButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addPlantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlantButton.Location = new System.Drawing.Point(1073, 96);
            this.addPlantButton.Name = "addPlantButton";
            this.addPlantButton.Size = new System.Drawing.Size(153, 57);
            this.addPlantButton.TabIndex = 72;
            this.addPlantButton.Text = "Додати рослину до продукта";
            this.addPlantButton.UseVisualStyleBackColor = false;
            this.addPlantButton.Click += new System.EventHandler(this.addPlantButton_Click);
            // 
            // addIllnessButton
            // 
            this.addIllnessButton.BackColor = System.Drawing.Color.Honeydew;
            this.addIllnessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.addIllnessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addIllnessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIllnessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIllnessButton.Location = new System.Drawing.Point(1073, 399);
            this.addIllnessButton.Name = "addIllnessButton";
            this.addIllnessButton.Size = new System.Drawing.Size(153, 57);
            this.addIllnessButton.TabIndex = 73;
            this.addIllnessButton.Text = "Додати хворобу до продукта";
            this.addIllnessButton.UseVisualStyleBackColor = false;
            this.addIllnessButton.Click += new System.EventHandler(this.addIllnessButton_Click);
            // 
            // deletePlantButton
            // 
            this.deletePlantButton.BackColor = System.Drawing.Color.MistyRose;
            this.deletePlantButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.deletePlantButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.deletePlantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlantButton.Location = new System.Drawing.Point(1073, 254);
            this.deletePlantButton.Name = "deletePlantButton";
            this.deletePlantButton.Size = new System.Drawing.Size(168, 53);
            this.deletePlantButton.TabIndex = 74;
            this.deletePlantButton.Text = "Видалити рослину\r\nз вибірки";
            this.deletePlantButton.UseVisualStyleBackColor = false;
            this.deletePlantButton.Click += new System.EventHandler(this.deletePlantButton_Click);
            // 
            // deleteIllnessButton
            // 
            this.deleteIllnessButton.BackColor = System.Drawing.Color.MistyRose;
            this.deleteIllnessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.deleteIllnessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.deleteIllnessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteIllnessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIllnessButton.Location = new System.Drawing.Point(1073, 550);
            this.deleteIllnessButton.Name = "deleteIllnessButton";
            this.deleteIllnessButton.Size = new System.Drawing.Size(168, 53);
            this.deleteIllnessButton.TabIndex = 75;
            this.deleteIllnessButton.Text = "Видалити хворобу\r\nз вибірки";
            this.deleteIllnessButton.UseVisualStyleBackColor = false;
            this.deleteIllnessButton.Click += new System.EventHandler(this.deleteIllnessButton_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 708);
            this.Controls.Add(this.deleteIllnessButton);
            this.Controls.Add(this.deletePlantButton);
            this.Controls.Add(this.addIllnessButton);
            this.Controls.Add(this.addPlantButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addedIllnessDataGridView);
            this.Controls.Add(this.illnessDataGridView);
            this.Controls.Add(this.addedPlantDataGridView);
            this.Controls.Add(this.plantDataGridView);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.contraindicationsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.methodOfApplicationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProductForm";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinal_PlantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedPlantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illnessDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedIllnessDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contraindicationsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox methodOfApplicationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox brandComboBox;
        private MedicinalPlantAphotecaryDataSet medicinalPlantAphotecaryDataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private MedicinalPlantAphotecaryDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource medicinal_PlantBindingSource;
        private MedicinalPlantAphotecaryDataSetTableAdapters.Medicinal_PlantTableAdapter medicinal_PlantTableAdapter;
        private MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView plantDataGridView;
        private System.Windows.Forms.DataGridView addedPlantDataGridView;
        private System.Windows.Forms.DataGridView illnessDataGridView;
        private System.Windows.Forms.DataGridView addedIllnessDataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button addPlantButton;
        private System.Windows.Forms.Button addIllnessButton;
        private MedicinalPlantAphotecaryDataSetTableAdapters.IllnessTableAdapter illnessTableAdapter;
        private MedicinalPlantAphotecaryDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button deletePlantButton;
        private System.Windows.Forms.Button deleteIllnessButton;
    }
}