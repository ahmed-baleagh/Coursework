namespace TransportationAccountingSystemWFA.Forms
{
    partial class CargoVehicleForm
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
            dgvVehicles = new DataGridView();
            btnAddCargoVehicle = new Button();
            btnUpdateCargoVehicle = new Button();
            btnDeleteCargoVehicle = new Button();
            label1 = new Label();
            txtStateNumber = new TextBox();
            txtModel = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtMileage = new TextBox();
            txtCargoCapacity = new TextBox();
            label4 = new Label();
            dtpReleaseDate = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            SuspendLayout();
            // 
            // dgvVehicles
            // 
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Location = new Point(434, 92);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.RowHeadersWidth = 51;
            dgvVehicles.RowTemplate.Height = 29;
            dgvVehicles.Size = new Size(528, 304);
            dgvVehicles.TabIndex = 0;
            // 
            // btnAddCargoVehicle
            // 
            btnAddCargoVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCargoVehicle.Location = new Point(12, 367);
            btnAddCargoVehicle.Name = "btnAddCargoVehicle";
            btnAddCargoVehicle.Size = new Size(99, 29);
            btnAddCargoVehicle.TabIndex = 1;
            btnAddCargoVehicle.Text = "CREATE";
            btnAddCargoVehicle.UseVisualStyleBackColor = true;
            btnAddCargoVehicle.Click += btnAddCargoVehicle_Click;
            // 
            // btnUpdateCargoVehicle
            // 
            btnUpdateCargoVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCargoVehicle.Location = new Point(141, 367);
            btnUpdateCargoVehicle.Name = "btnUpdateCargoVehicle";
            btnUpdateCargoVehicle.Size = new Size(98, 29);
            btnUpdateCargoVehicle.TabIndex = 2;
            btnUpdateCargoVehicle.Text = "UPDATE";
            btnUpdateCargoVehicle.UseVisualStyleBackColor = true;
            btnUpdateCargoVehicle.Click += btnUpdateCargoVehicle_Click;
            // 
            // btnDeleteCargoVehicle
            // 
            btnDeleteCargoVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCargoVehicle.Location = new Point(256, 367);
            btnDeleteCargoVehicle.Name = "btnDeleteCargoVehicle";
            btnDeleteCargoVehicle.Size = new Size(109, 29);
            btnDeleteCargoVehicle.TabIndex = 3;
            btnDeleteCargoVehicle.Text = "DELETE";
            btnDeleteCargoVehicle.UseVisualStyleBackColor = true;
            btnDeleteCargoVehicle.Click += btnDeleteCargoVehicle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 92);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 4;
            label1.Text = "StateNumber";
            // 
            // txtStateNumber
            // 
            txtStateNumber.Location = new Point(28, 123);
            txtStateNumber.Name = "txtStateNumber";
            txtStateNumber.Size = new Size(131, 27);
            txtStateNumber.TabIndex = 5;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(28, 201);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(131, 27);
            txtModel.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 178);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 7;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(222, 92);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 8;
            label3.Text = "Mileage";
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(222, 123);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(131, 27);
            txtMileage.TabIndex = 9;
            // 
            // txtCargoCapacity
            // 
            txtCargoCapacity.Location = new Point(222, 201);
            txtCargoCapacity.Name = "txtCargoCapacity";
            txtCargoCapacity.Size = new Size(131, 27);
            txtCargoCapacity.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(222, 178);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 11;
            label4.Text = "CargoCapacity";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(28, 289);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(250, 27);
            dtpReleaseDate.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 266);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 13;
            label5.Text = "RealeaseDate";
            // 
            // CargoVehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 455);
            Controls.Add(label5);
            Controls.Add(dtpReleaseDate);
            Controls.Add(label4);
            Controls.Add(txtCargoCapacity);
            Controls.Add(txtMileage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(txtStateNumber);
            Controls.Add(label1);
            Controls.Add(btnDeleteCargoVehicle);
            Controls.Add(btnUpdateCargoVehicle);
            Controls.Add(btnAddCargoVehicle);
            Controls.Add(dgvVehicles);
            Name = "CargoVehicleForm";
            Text = "CargoVehicleForm";
            Load += CargoVehicleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVehicles;
        private Button btnAddCargoVehicle;
        private Button btnUpdateCargoVehicle;
        private Button btnDeleteCargoVehicle;
        private Label label1;
        private TextBox txtStateNumber;
        private TextBox txtModel;
        private Label label2;
        private Label label3;
        private TextBox txtMileage;
        private TextBox txtCargoCapacity;
        private Label label4;
        private DateTimePicker dtpReleaseDate;
        private Label label5;
    }
}