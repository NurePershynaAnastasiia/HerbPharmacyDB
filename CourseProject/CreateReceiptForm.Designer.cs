namespace CourseProject
{
    partial class CreateReceiptForm
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
            this.medicinalPlantAphotecaryDataSet = new CourseProject.MedicinalPlantAphotecaryDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.receiptDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.printersList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.clientCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardCheckBox = new System.Windows.Forms.CheckBox();
            this.client_CardTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.Client_CardTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(-42, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 39);
            this.panel1.TabIndex = 8;
            // 
            // medicinalPlantAphotecaryDataSet
            // 
            this.medicinalPlantAphotecaryDataSet.DataSetName = "MedicinalPlantAphotecaryDataSet";
            this.medicinalPlantAphotecaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.medicinalPlantAphotecaryDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.Client_CardTableAdapter = null;
            this.tableAdapterManager.IllnessTableAdapter = null;
            this.tableAdapterManager.Medicinal_PlantTableAdapter = null;
            this.tableAdapterManager.Plant_in_ProductTableAdapter = null;
            this.tableAdapterManager.Product_from_IllnessTableAdapter = null;
            this.tableAdapterManager.Product_QuantityTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 126);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(461, 186);
            this.productsDataGridView.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Наявні продукти";
            // 
            // receiptDataGridView
            // 
            this.receiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptDataGridView.Location = new System.Drawing.Point(12, 389);
            this.receiptDataGridView.Name = "receiptDataGridView";
            this.receiptDataGridView.Size = new System.Drawing.Size(461, 186);
            this.receiptDataGridView.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Продукти в чеці";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Кількість:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Honeydew;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(506, 256);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(168, 56);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Додати продукт до покупки";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MistyRose;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(506, 494);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(183, 56);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Видалити продукт з покупки";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.printReceiptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.printReceiptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.printReceiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.Location = new System.Drawing.Point(515, 710);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(228, 81);
            this.printReceiptButton.TabIndex = 27;
            this.printReceiptButton.Text = "Роздрукувати чек";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(515, 189);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.quantityNumericUpDown.TabIndex = 28;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // printersList
            // 
            this.printersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printersList.FormattingEnabled = true;
            this.printersList.Location = new System.Drawing.Point(12, 750);
            this.printersList.Name = "printersList";
            this.printersList.Size = new System.Drawing.Size(263, 32);
            this.printersList.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 722);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Оберіть принтер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Оберіть власника картки:";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientCardBindingSource;
            this.clientComboBox.DisplayMember = "Client_Name";
            this.clientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(210, 633);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(263, 32);
            this.clientComboBox.TabIndex = 32;
            this.clientComboBox.ValueMember = "Client_Card_id";
            // 
            // clientCardBindingSource
            // 
            this.clientCardBindingSource.DataMember = "Client_Card";
            this.clientCardBindingSource.DataSource = this.medicinalPlantAphotecaryDataSet;
            // 
            // cardCheckBox
            // 
            this.cardCheckBox.AutoSize = true;
            this.cardCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardCheckBox.Location = new System.Drawing.Point(12, 631);
            this.cardCheckBox.Name = "cardCheckBox";
            this.cardCheckBox.Size = new System.Drawing.Size(112, 33);
            this.cardCheckBox.TabIndex = 34;
            this.cardCheckBox.Text = "Картка";
            this.cardCheckBox.UseVisualStyleBackColor = true;
            // 
            // client_CardTableAdapter
            // 
            this.client_CardTableAdapter.ClearBeforeFill = true;
            // 
            // CreateReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 803);
            this.Controls.Add(this.cardCheckBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.printersList);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiptDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "CreateReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateReceiptForm";
            this.Load += new System.EventHandler(this.CreateReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MedicinalPlantAphotecaryDataSet medicinalPlantAphotecaryDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MedicinalPlantAphotecaryDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView receiptDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.ComboBox printersList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.CheckBox cardCheckBox;
        private System.Windows.Forms.BindingSource clientCardBindingSource;
        private MedicinalPlantAphotecaryDataSetTableAdapters.Client_CardTableAdapter client_CardTableAdapter;
    }
}