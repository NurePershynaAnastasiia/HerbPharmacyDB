namespace CourseProject
{
    partial class StatisticsForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.medicinalPlantAphotecaryDataSet = new CourseProject.MedicinalPlantAphotecaryDataSet();
            this.productTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager();
            this.statisticsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(395, 37);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Найпопулярніші продукти";
            // 
            // medicinalPlantAphotecaryDataSet
            // 
            this.medicinalPlantAphotecaryDataSet.DataSetName = "MedicinalPlantAphotecaryDataSet";
            this.medicinalPlantAphotecaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // statisticsDataGridView
            // 
            this.statisticsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsDataGridView.Location = new System.Drawing.Point(63, 169);
            this.statisticsDataGridView.Name = "statisticsDataGridView";
            this.statisticsDataGridView.Size = new System.Drawing.Size(388, 363);
            this.statisticsDataGridView.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 39);
            this.panel1.TabIndex = 7;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statisticsDataGridView);
            this.Controls.Add(this.nameLabel);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private MedicinalPlantAphotecaryDataSet medicinalPlantAphotecaryDataSet;
        private MedicinalPlantAphotecaryDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private MedicinalPlantAphotecaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView statisticsDataGridView;
        private System.Windows.Forms.Panel panel1;
    }
}