using TransportationAccountingSystemWFA.Helpers;
using TransportationAccountingSystemWFA.Repositories.Implementations;

namespace TransportationAccountingSystemWFA.Forms
{
    public partial class CargoPassengerVehicleForm : Form
    {
        private CargoPassengerVehicleRepository cargoPassengerVehicleRepo;
        public CargoPassengerVehicleForm()
        {
            InitializeComponent();
            cargoPassengerVehicleRepo = new CargoPassengerVehicleRepository();
        }

        private void CargoPassengerVehicleForm_Load(object sender, EventArgs e)
        {
            LoadCargoPassengerVehicles();
        }

        private void btnAddCargoPassengerVehicle_Click(object sender, EventArgs e)
        {
            // Gather input from form fields
            string stateNumber = txtStateNumber.Text;
            string model = txtModel.Text;
            DateTime releaseDate = dtpReleaseDate.Value;
            int mileage = int.Parse(txtMileage.Text);
            int cargoCapacity = int.Parse(txtCargoCapacity.Text);
            int passengerCapacity = int.Parse(txtCargoCapacity.Text);

            // Create CargoPassengerVehicle object
            CargoPassengerVehicle cargoPassengerVehicle = new CargoPassengerVehicle
            {
                StateNumber = stateNumber,
                Model = int.Parse(model),
                ReleaseDate = releaseDate,
                Mileage = mileage,
                CargoCapacity = cargoCapacity,
                PassengerCapacity = passengerCapacity
            };

            // Add cargo passenger vehicle to database
            cargoPassengerVehicleRepo.AddVehicle(cargoPassengerVehicle);

            // Refresh data grid view
            LoadCargoPassengerVehicles();
        }

        private void btnUpdateCargoPassengerVehicle_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvCargoPassengerVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a cargo passenger vehicle to update.");
                return;
            }

            // Gather input from form fields
            int selectedRowIndex = dgvCargoPassengerVehicles.SelectedRows[0].Index;
            int vehicleId = (int)dgvCargoPassengerVehicles.Rows[selectedRowIndex].Cells["VehicleId"].Value;
            string stateNumber = txtStateNumber.Text;
            string model = txtModel.Text;
            DateTime releaseDate = dtpReleaseDate.Value;
            int mileage = int.Parse(txtMileage.Text);
            int cargoCapacity = int.Parse(txtCargoCapacity.Text);
            int passengerCapacity = int.Parse(txtPassengerCapacity.Text);

            // Create CargoPassengerVehicle object
            CargoPassengerVehicle cargoPassengerVehicle = new CargoPassengerVehicle
            {
                VehicleId = vehicleId,
                StateNumber = stateNumber,
                Model = int.Parse(model),
                ReleaseDate = releaseDate,
                Mileage = mileage,
                CargoCapacity = cargoCapacity,
                PassengerCapacity = passengerCapacity
            };

            // Update cargo passenger vehicle in database
            cargoPassengerVehicleRepo.UpdateVehicle(cargoPassengerVehicle);

            // Refresh data grid view
            LoadCargoPassengerVehicles();
        }

        private void btnDeleteCargoPassengerVehicle_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvCargoPassengerVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a cargo passenger vehicle to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this cargo passenger vehicle?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Get the vehicle ID from the selected row
                int selectedRowIndex = dgvCargoPassengerVehicles.SelectedRows[0].Index;
                int vehicleId = (int)dgvCargoPassengerVehicles.Rows[selectedRowIndex].Cells["VehicleId"].Value;

                // Delete the cargo passenger vehicle from the database
                cargoPassengerVehicleRepo.DeleteVehicle(vehicleId);

                // Refresh data grid view
                LoadCargoPassengerVehicles();
            }
        }

        private void LoadCargoPassengerVehicles()
        {
            List<CargoPassengerVehicle> cargoPassengerVehicles = cargoPassengerVehicleRepo.GetAllVehicles();
            dgvCargoPassengerVehicles.DataSource = cargoPassengerVehicles;
        }
    }
}
