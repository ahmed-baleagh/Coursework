namespace TransportationAccountingSystemWFA.Forms
{
    partial class PassengerVehicleForm
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
            dgvPassengerVehicles = new DataGridView();
            btnAddPassengerVehicle = new Button();
            btnUpdatepassengerVehicle = new Button();
            btnDeletePassengerVehicle = new Button();
            label1 = new Label();
            txtStateNumber = new TextBox();
            txtModel = new Label();
            textBox1 = new TextBox();
            txtPassengerCapacity = new TextBox();
            PassengerCapacity = new Label();
            txtMileage = new TextBox();
            Mileage = new Label();
            dtpReleaseDate = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPassengerVehicles).BeginInit();
            SuspendLayout();
            // 
            // dgvPassengerVehicles
            // 
            dgvPassengerVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPassengerVehicles.Location = new Point(540, 93);
            dgvPassengerVehicles.Name = "dgvPassengerVehicles";
            dgvPassengerVehicles.RowHeadersWidth = 51;
            dgvPassengerVehicles.RowTemplate.Height = 29;
            dgvPassengerVehicles.Size = new Size(442, 292);
            dgvPassengerVehicles.TabIndex = 0;
            // 
            // btnAddPassengerVehicle
            // 
            btnAddPassengerVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPassengerVehicle.Location = new Point(54, 356);
            btnAddPassengerVehicle.Name = "btnAddPassengerVehicle";
            btnAddPassengerVehicle.Size = new Size(94, 29);
            btnAddPassengerVehicle.TabIndex = 1;
            btnAddPassengerVehicle.Text = "CREATE";
            btnAddPassengerVehicle.UseVisualStyleBackColor = true;
            btnAddPassengerVehicle.Click += btnAddPassengerVehicle_Click;
            // 
            // btnUpdatepassengerVehicle
            // 
            btnUpdatepassengerVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatepassengerVehicle.Location = new Point(188, 356);
            btnUpdatepassengerVehicle.Name = "btnUpdatepassengerVehicle";
            btnUpdatepassengerVehicle.Size = new Size(94, 29);
            btnUpdatepassengerVehicle.TabIndex = 2;
            btnUpdatepassengerVehicle.Text = "UPDATE";
            btnUpdatepassengerVehicle.UseVisualStyleBackColor = true;
            btnUpdatepassengerVehicle.Click += btnUpdatepassengerVehicle_Click;
            // 
            // btnDeletePassengerVehicle
            // 
            btnDeletePassengerVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeletePassengerVehicle.Location = new Point(321, 356);
            btnDeletePassengerVehicle.Name = "btnDeletePassengerVehicle";
            btnDeletePassengerVehicle.Size = new Size(94, 29);
            btnDeletePassengerVehicle.TabIndex = 3;
            btnDeletePassengerVehicle.Text = "DELETE";
            btnDeletePassengerVehicle.UseVisualStyleBackColor = true;
            btnDeletePassengerVehicle.Click += btnDeletePassengerVehicle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 93);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 4;
            label1.Text = "StateNumber";
            // 
            // txtStateNumber
            // 
            txtStateNumber.Location = new Point(49, 127);
            txtStateNumber.Name = "txtStateNumber";
            txtStateNumber.Size = new Size(125, 27);
            txtStateNumber.TabIndex = 5;
            // 
            // txtModel
            // 
            txtModel.AutoSize = true;
            txtModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtModel.Location = new Point(49, 182);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(53, 20);
            txtModel.TabIndex = 6;
            txtModel.Text = "Model";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // txtPassengerCapacity
            // 
            txtPassengerCapacity.Location = new Point(300, 218);
            txtPassengerCapacity.Name = "txtPassengerCapacity";
            txtPassengerCapacity.Size = new Size(125, 27);
            txtPassengerCapacity.TabIndex = 11;
            // 
            // PassengerCapacity
            // 
            PassengerCapacity.AutoSize = true;
            PassengerCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PassengerCapacity.Location = new Point(300, 182);
            PassengerCapacity.Name = "PassengerCapacity";
            PassengerCapacity.Size = new Size(139, 20);
            PassengerCapacity.TabIndex = 10;
            PassengerCapacity.Text = "PassengerCapacity";
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(300, 127);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(125, 27);
            txtMileage.TabIndex = 9;
            // 
            // Mileage
            // 
            Mileage.AutoSize = true;
            Mileage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Mileage.Location = new Point(300, 93);
            Mileage.Name = "Mileage";
            Mileage.Size = new Size(64, 20);
            Mileage.TabIndex = 8;
            Mileage.Text = "Mileage";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(54, 297);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(250, 27);
            dtpReleaseDate.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(54, 274);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 13;
            label5.Text = "ReleaseDate";
            // 
            // PassengerVehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 450);
            Controls.Add(label5);
            Controls.Add(dtpReleaseDate);
            Controls.Add(txtPassengerCapacity);
            Controls.Add(PassengerCapacity);
            Controls.Add(txtMileage);
            Controls.Add(Mileage);
            Controls.Add(textBox1);
            Controls.Add(txtModel);
            Controls.Add(txtStateNumber);
            Controls.Add(label1);
            Controls.Add(btnDeletePassengerVehicle);
            Controls.Add(btnUpdatepassengerVehicle);
            Controls.Add(btnAddPassengerVehicle);
            Controls.Add(dgvPassengerVehicles);
            Name = "PassengerVehicleForm";
            Text = "PassengerVehicleForm";
            Load += PassengerVehicleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPassengerVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPassengerVehicles;
        private Button btnAddPassengerVehicle;
        private Button btnUpdatepassengerVehicle;
        private Button btnDeletePassengerVehicle;
        private Label label1;
        private TextBox txtStateNumber;
        private Label txtModel;
        private TextBox textBox1;
        private TextBox txtPassengerCapacity;
        private Label PassengerCapacity;
        private TextBox txtMileage;
        private Label Mileage;
        private DateTimePicker dtpReleaseDate;
        private Label label5;
    }
}