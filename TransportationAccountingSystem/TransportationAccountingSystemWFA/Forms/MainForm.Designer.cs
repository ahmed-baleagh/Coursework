namespace TransportationAccountingSystemWFA.Forms
{
    partial class MainForm
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
            dataGridView = new DataGridView();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            Destination = new Label();
            txtDestination = new TextBox();
            btnGenerateVehicleReport = new Button();
            btnGenerateDestinationReport = new Button();
            menuStrip1 = new MenuStrip();
            cargoPassengerFormToolStripMenuItem = new ToolStripMenuItem();
            cargoVehicleFormToolStripMenuItem = new ToolStripMenuItem();
            passenegerVehicleformToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(363, 115);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(578, 284);
            dataGridView.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(31, 115);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(31, 169);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 2;
            // 
            // Destination
            // 
            Destination.AutoSize = true;
            Destination.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Destination.Location = new Point(32, 233);
            Destination.Name = "Destination";
            Destination.Size = new Size(90, 20);
            Destination.TabIndex = 3;
            Destination.Text = "Destination";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(31, 268);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(211, 27);
            txtDestination.TabIndex = 4;
            // 
            // btnGenerateVehicleReport
            // 
            btnGenerateVehicleReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerateVehicleReport.Location = new Point(31, 324);
            btnGenerateVehicleReport.Name = "btnGenerateVehicleReport";
            btnGenerateVehicleReport.Size = new Size(211, 29);
            btnGenerateVehicleReport.TabIndex = 5;
            btnGenerateVehicleReport.Text = "GenerateVehicleReport";
            btnGenerateVehicleReport.UseVisualStyleBackColor = true;
            btnGenerateVehicleReport.Click += btnGenerateVehicleReport_Click;
            // 
            // btnGenerateDestinationReport
            // 
            btnGenerateDestinationReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerateDestinationReport.Location = new Point(31, 370);
            btnGenerateDestinationReport.Name = "btnGenerateDestinationReport";
            btnGenerateDestinationReport.Size = new Size(211, 29);
            btnGenerateDestinationReport.TabIndex = 6;
            btnGenerateDestinationReport.Text = "GenerateDestinationReport";
            btnGenerateDestinationReport.UseVisualStyleBackColor = true;
            btnGenerateDestinationReport.Click += btnGenerateDestinationReport_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cargoPassengerFormToolStripMenuItem, cargoVehicleFormToolStripMenuItem, passenegerVehicleformToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1047, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // cargoPassengerFormToolStripMenuItem
            // 
            cargoPassengerFormToolStripMenuItem.Name = "cargoPassengerFormToolStripMenuItem";
            cargoPassengerFormToolStripMenuItem.Size = new Size(209, 24);
            cargoPassengerFormToolStripMenuItem.Text = "CargoPassengerVehicleForm";
            cargoPassengerFormToolStripMenuItem.Click += cargoPassengerFormToolStripMenuItem_Click;
            // 
            // cargoVehicleFormToolStripMenuItem
            // 
            cargoVehicleFormToolStripMenuItem.Name = "cargoVehicleFormToolStripMenuItem";
            cargoVehicleFormToolStripMenuItem.Size = new Size(144, 24);
            cargoVehicleFormToolStripMenuItem.Text = "CargoVehicleForm";
            cargoVehicleFormToolStripMenuItem.Click += cargoVehicleFormToolStripMenuItem_Click;
            // 
            // passenegerVehicleformToolStripMenuItem
            // 
            passenegerVehicleformToolStripMenuItem.Name = "passenegerVehicleformToolStripMenuItem";
            passenegerVehicleformToolStripMenuItem.Size = new Size(167, 24);
            passenegerVehicleformToolStripMenuItem.Text = "PassengerVehicleform";
            passenegerVehicleformToolStripMenuItem.Click += passenegerVehicleformToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 539);
            Controls.Add(btnGenerateDestinationReport);
            Controls.Add(btnGenerateVehicleReport);
            Controls.Add(txtDestination);
            Controls.Add(Destination);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label Destination;
        private TextBox txtDestination;
        private Button btnGenerateVehicleReport;
        private Button btnGenerateDestinationReport;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cargoPassengerFormToolStripMenuItem;
        private ToolStripMenuItem cargoVehicleFormToolStripMenuItem;
        private ToolStripMenuItem passenegerVehicleformToolStripMenuItem;
    }
}