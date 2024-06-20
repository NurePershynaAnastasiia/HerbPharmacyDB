namespace CourseProject
{
    partial class EditPurchaseForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.cardComboBox = new System.Windows.Forms.ComboBox();
            this.clientCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinalPlantAphotecaryDataSet = new CourseProject.MedicinalPlantAphotecaryDataSet();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.PurchaseTableAdapter();
            this.client_CardTableAdapter = new CourseProject.MedicinalPlantAphotecaryDataSetTableAdapters.Client_CardTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(385, 425);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 44);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(104, 425);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(142, 44);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Власник картки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cума";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumTextBox.Location = new System.Drawing.Point(317, 200);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(264, 31);
            this.sumTextBox.TabIndex = 12;
            // 
            // cardComboBox
            // 
            this.cardComboBox.DataSource = this.clientCardBindingSource;
            this.cardComboBox.DisplayMember = "Client_Name";
            this.cardComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardComboBox.FormattingEnabled = true;
            this.cardComboBox.Location = new System.Drawing.Point(317, 290);
            this.cardComboBox.Name = "cardComboBox";
            this.cardComboBox.Size = new System.Drawing.Size(264, 33);
            this.cardComboBox.TabIndex = 11;
            this.cardComboBox.ValueMember = "Client_Card_id";
            // 
            // clientCardBindingSource
            // 
            this.clientCardBindingSource.DataMember = "Client_Card";
            this.clientCardBindingSource.DataSource = this.medicinalPlantAphotecaryDataSet;
            // 
            // medicinalPlantAphotecaryDataSet
            // 
            this.medicinalPlantAphotecaryDataSet.DataSetName = "MedicinalPlantAphotecaryDataSet";
            this.medicinalPlantAphotecaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(317, 109);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(264, 31);
            this.dateTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Покупка";
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // client_CardTableAdapter
            // 
            this.client_CardTableAdapter.ClearBeforeFill = true;
            // 
            // EditPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 522);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.cardComboBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPurchaseForm";
            this.Load += new System.EventHandler(this.EditPurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinalPlantAphotecaryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.ComboBox cardComboBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label1;
        private MedicinalPlantAphotecaryDataSet medicinalPlantAphotecaryDataSet;
        private MedicinalPlantAphotecaryDataSetTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.BindingSource clientCardBindingSource;
        private MedicinalPlantAphotecaryDataSetTableAdapters.Client_CardTableAdapter client_CardTableAdapter;
    }
}