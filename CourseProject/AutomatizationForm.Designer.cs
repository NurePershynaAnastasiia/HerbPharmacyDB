namespace CourseProject
{
    partial class AutomatizationForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.medicinalPlantAphotecaryDataSet = new CourseProject.MedicinalPlantAphotecaryDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.orderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(-155, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 55);
            this.panel1.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(46, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(471, 42);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Непідписані замовлення";
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
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(91, 153);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(405, 297);
            this.ordersDataGridView.TabIndex = 11;
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.orderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.orderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.orderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(163, 491);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(228, 61);
            this.orderButton.TabIndex = 28;
            this.orderButton.Text = "Замовити";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // AutomatizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 564);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AutomatizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutomatizationForm";
            this.Load += new System.EventHandler(this.AutomatizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private MedicinalPlantAphotecaryDataSet medicinalPlantAphotecaryDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MedicinalPlantAphotecaryDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button orderButton;
    }
}