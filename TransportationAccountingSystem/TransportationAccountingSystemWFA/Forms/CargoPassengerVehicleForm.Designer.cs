namespace TransportationAccountingSystemWFA.Forms
{
    partial class CargoPassengerVehicleForm
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
            dgvCargoPassengerVehicles = new DataGridView();
            btnAddCargoPassengerVehicle = new Button();
            btnUpdateCargoPassengerVehicle = new Button();
            btnDeleteCargoPassengerVehicle = new Button();
            label5 = new Label();
            dtpReleaseDate = new DateTimePicker();
            label4 = new Label();
            txtCargoCapacity = new TextBox();
            txtMileage = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtModel = new TextBox();
            txtStateNumber = new TextBox();
            label6 = new Label();
            label1 = new Label();
            txtPassengerCapacity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCargoPassengerVehicles).BeginInit();
            SuspendLayout();
            // 
            // dgvCargoPassengerVehicles
            // 
            dgvCargoPassengerVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargoPassengerVehicles.Location = new Point(448, 88);
            dgvCargoPassengerVehicles.Name = "dgvCargoPassengerVehicles";
            dgvCargoPassengerVehicles.RowHeadersWidth = 51;
            dgvCargoPassengerVehicles.RowTemplate.Height = 29;
            dgvCargoPassengerVehicles.Size = new Size(480, 337);
            dgvCargoPassengerVehicles.TabIndex = 0;
            // 
            // btnAddCargoPassengerVehicle
            // 
            btnAddCargoPassengerVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCargoPassengerVehicle.Location = new Point(10, 399);
            btnAddCargoPassengerVehicle.Name = "btnAddCargoPassengerVehicle";
            btnAddCargoPassengerVehicle.Size = new Size(94, 29);
            btnAddCargoPassengerVehicle.TabIndex = 1;
            btnAddCargoPassengerVehicle.Text = "CREATE";
            btnAddCargoPassengerVehicle.UseVisualStyleBackColor = true;
            btnAddCargoPassengerVehicle.Click += btnAddCargoPassengerVehicle_Click;
            // 
            // btnUpdateCargoPassengerVehicle
            // 
            btnUpdateCargoPassengerVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCargoPassengerVehicle.Location = new Point(137, 399);
            btnUpdateCargoPassengerVehicle.Name = "btnUpdateCargoPassengerVehicle";
            btnUpdateCargoPassengerVehicle.Size = new Size(94, 29);
            btnUpdateCargoPassengerVehicle.TabIndex = 2;
            btnUpdateCargoPassengerVehicle.Text = "UPDATE";
            btnUpdateCargoPassengerVehicle.UseVisualStyleBackColor = true;
            btnUpdateCargoPassengerVehicle.Click += btnUpdateCargoPassengerVehicle_Click;
            // 
            // btnDeleteCargoPassengerVehicle
            // 
            btnDeleteCargoPassengerVehicle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCargoPassengerVehicle.Location = new Point(272, 399);
            btnDeleteCargoPassengerVehicle.Name = "btnDeleteCargoPassengerVehicle";
            btnDeleteCargoPassengerVehicle.Size = new Size(94, 29);
            btnDeleteCargoPassengerVehicle.TabIndex = 3;
            btnDeleteCargoPassengerVehicle.Text = "DELETE";
            btnDeleteCargoPassengerVehicle.UseVisualStyleBackColor = true;
            btnDeleteCargoPassengerVehicle.Click += btnDeleteCargoPassengerVehicle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 322);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 23;
            label5.Text = "RealeaseDate";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(12, 345);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(250, 27);
            dtpReleaseDate.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(272, 178);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 21;
            label4.Text = "CargoCapacity";
            // 
            // txtCargoCapacity
            // 
            txtCargoCapacity.Location = new Point(272, 201);
            txtCargoCapacity.Name = "txtCargoCapacity";
            txtCargoCapacity.Size = new Size(131, 27);
            txtCargoCapacity.TabIndex = 20;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(272, 123);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(131, 27);
            txtMileage.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(272, 92);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 18;
            label3.Text = "Mileage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 17;
            label2.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(12, 201);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(131, 27);
            txtModel.TabIndex = 16;
            // 
            // txtStateNumber
            // 
            txtStateNumber.Location = new Point(12, 123);
            txtStateNumber.Name = "txtStateNumber";
            txtStateNumber.Size = new Size(131, 27);
            txtStateNumber.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 92);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 14;
            label6.Text = "StateNumber";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(272, 251);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 25;
            label1.Text = "PassengerCapacity";
            // 
            // txtPassengerCapacity
            // 
            txtPassengerCapacity.Location = new Point(272, 274);
            txtPassengerCapacity.Name = "txtPassengerCapacity";
            txtPassengerCapacity.Size = new Size(131, 27);
            txtPassengerCapacity.TabIndex = 24;
            // 
            // CargoPassengerVehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 484);
            Controls.Add(label1);
            Controls.Add(txtPassengerCapacity);
            Controls.Add(label5);
            Controls.Add(dtpReleaseDate);
            Controls.Add(label4);
            Controls.Add(txtCargoCapacity);
            Controls.Add(txtMileage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(txtStateNumber);
            Controls.Add(label6);
            Controls.Add(btnDeleteCargoPassengerVehicle);
            Controls.Add(btnUpdateCargoPassengerVehicle);
            Controls.Add(btnAddCargoPassengerVehicle);
            Controls.Add(dgvCargoPassengerVehicles);
            Name = "CargoPassengerVehicleForm";
            Text = "CargoPassengerVehicleForm";
            Load += CargoPassengerVehicleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCargoPassengerVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCargoPassengerVehicles;
        private Button btnAddCargoPassengerVehicle;
        private Button btnUpdateCargoPassengerVehicle;
        private Button btnDeleteCargoPassengerVehicle;
        private Label label5;
        private DateTimePicker dtpReleaseDate;
        private Label label4;
        private TextBox txtCargoCapacity;
        private TextBox txtMileage;
        private Label label3;
        private Label label2;
        private TextBox txtModel;
        private TextBox txtStateNumber;
        private Label label6;
        private Label label1;
        private TextBox txtPassengerCapacity;
    }
}