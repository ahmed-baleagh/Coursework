using TransportationAccountingSystemWFA.Helpers;
using TransportationAccountingSystemWFA.Repositories.Implementations;

namespace TransportationAccountingSystemWFA.Forms
{
    public partial class PassengerVehicleForm : Form
    {
        private PassengerVehicleRepository passengerVehicleRepo;
        public PassengerVehicleForm()
        {
            InitializeComponent();
            passengerVehicleRepo = new PassengerVehicleRepository();
        }

        private void PassengerVehicleForm_Load(object sender, EventArgs e)
        {
            LoadPassengerVehicles();
        }

        private void btnAddPassengerVehicle_Click(object sender, EventArgs e)
        {
            // Gather input from form fields
            string stateNumber = txtStateNumber.Text;
            string model = txtModel.Text;
            DateTime releaseDate = dtpReleaseDate.Value;
            int mileage = int.Parse(txtMileage.Text);
            int passengerCapacity = int.Parse(txtPassengerCapacity.Text);

            // Create PassengerVehicle object
            PassengerVehicle passengerVehicle = new PassengerVehicle
            {
                StateNumber = stateNumber,
                Model = int.Parse(model),
                ReleaseDate = releaseDate,
                Mileage = mileage,
                PassengerCapacity = passengerCapacity
            };

            // Add passenger vehicle to database
            passengerVehicleRepo.AddVehicle(passengerVehicle);

            // Refresh data grid view
            LoadPassengerVehicles();
        }

        private void btnUpdatepassengerVehicle_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvPassengerVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a passenger vehicle to update.");
                return;
            }

            // Gather input from form fields
            int selectedRowIndex = dgvPassengerVehicles.SelectedRows[0].Index;
            int vehicleId = (int)dgvPassengerVehicles.Rows[selectedRowIndex].Cells["VehicleId"].Value;
            string stateNumber = txtStateNumber.Text;
            string model = txtModel.Text;
            DateTime releaseDate = dtpReleaseDate.Value;
            int mileage = int.Parse(txtMileage.Text);
            int passengerCapacity = int.Parse(txtPassengerCapacity.Text);

            // Create PassengerVehicle object
            PassengerVehicle passengerVehicle = new PassengerVehicle
            {
                VehicleId = vehicleId,
                StateNumber = stateNumber,
                Model = int.Parse(model),
                ReleaseDate = releaseDate,
                Mileage = mileage,
                PassengerCapacity = passengerCapacity
            };

            // Update passenger vehicle in database
            passengerVehicleRepo.UpdateVehicle(passengerVehicle);

            // Refresh data grid view
            LoadPassengerVehicles();
        }

        private void btnDeletePassengerVehicle_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvPassengerVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a passenger vehicle to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this passenger vehicle?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Get the vehicle ID from the selected row
                int selectedRowIndex = dgvPassengerVehicles.SelectedRows[0].Index;
                int vehicleId = (int)dgvPassengerVehicles.Rows[selectedRowIndex].Cells["VehicleId"].Value;

                // Delete the passenger vehicle from the database
                passengerVehicleRepo.DeleteVehicle(vehicleId);

                // Refresh data grid view
                LoadPassengerVehicles();
            }
        }
        private void LoadPassengerVehicles()
        {
            List<PassengerVehicle> passengerVehicles = passengerVehicleRepo.GetAllVehicles();
            dgvPassengerVehicles.DataSource = passengerVehicles;
        }
    }
}
