namespace Database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(112, 33);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(261, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Welcome to CRM";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(171, 110);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(263, 27);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(171, 253);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(263, 27);
            this.txtBoxAddress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address: ";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(171, 179);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(263, 27);
            this.txtBoxPhoneNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone Number: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(171, 318);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 44);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gridView
            // 
            this.gridView.CausesValidation = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPhoneNumber,
            this.colAddress});
            this.gridView.Location = new System.Drawing.Point(486, 110);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 29;
            this.gridView.Size = new System.Drawing.Size(491, 252);
            this.gridView.TabIndex = 9;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.HeaderText = "Phone Number";
            this.colPhoneNumber.MinimumWidth = 6;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            this.colPhoneNumber.Width = 125;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 409);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeading;
        private Label lblName;
        private TextBox txtBoxName;
        private TextBox txtBoxAddress;
        private Label label1;
        private TextBox txtBoxPhoneNumber;
        private Label label2;
        private Button btnSubmit;
        private DataGridView gridView;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colAddress;
    }
}