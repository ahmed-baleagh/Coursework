using TransportationAccountingSystemWFA.Helpers;
using TransportationAccountingSystemWFA.Repositories.Implementations;

namespace TransportationAccountingSystemWFA.Forms
{
    public partial class CargoVehicleForm : Form
    {
        private CargoVehicleRepository cargoVehicleRepo;
        public CargoVehicleForm()
        {
            InitializeComponent();
            cargoVehicleRepo = new CargoVehicleRepository();
        }

        private void CargoVehicleForm_Load(object sender, EventArgs e)
        {
            LoadCargoVehicles();
        }

        private void btnAddCargoVehicle_Click(object sender, EventArgs e)
        {
            // Gather input from form fields
            string stateNumber = txtStateNumber.Text;
            string model = txtModel.Text;
            DateTime releaseDate = dtpReleaseDate.Value;
            int mileage = int.Parse(txtMileage.Text);
            int cargoCapacity = int.Parse(txtCargoCapacity.Text);

            // Create CargoVehicle object
            CargoVehicle cargoVehicle = new CargoVehicle
            {
                StateNumber = stateNumber,
                Model = int.Parse(model),
                ReleaseDate = releaseDate,
                Mileage = mileage,
                CargoCapacity = cargoCapacity
            };

            // Add cargo vehicle to database
            cargoVehicleRepo.AddVehicle(cargoVehicle);

            // Refresh data grid view
            LoadCargoVehicles();
        }

        private void btnUpdateCargoVehicle_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a cargo vehicle to update.");
                return;
            }

            // Gather input from form fields
            int selectedRowIndex = dgvVehicles.SelectedRows[0].Index;
            int vehicleId = (int)dgvVehicles.Rows[selectedRowIndex].Cells["VehicleId"].Value;
            string stateNumber = txtStateNumber.Text;
            string model = txtModel.Text;
            DateTime releaseDate = dtpReleaseDate.Value;
            int mileage = int.Parse(txtMileage.Text);
            int cargoCapacity = int.Parse(txtCargoCapacity.Text);

            // Create CargoVehicle object
            CargoVehicle cargoVehicle = new CargoVehicle
            {
                VehicleId = vehicleId,
                StateNumber = stateNumber,
                Model = int.Parse(model),
                ReleaseDate = releaseDate,
                Mileage = mileage,
                CargoCapacity = cargoCapacity
            };

            // Update cargo vehicle in database
            cargoVehicleRepo.UpdateVehicle(cargoVehicle);

            // Refresh data grid view
            LoadCargoVehicles();
        }

        private void btnDeleteCargoVehicle_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a cargo vehicle to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this cargo vehicle?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Get the vehicle ID from the selected row
                int selectedRowIndex = dgvVehicles.SelectedRows[0].Index;
                int vehicleId = (int)dgvVehicles.Rows[selectedRowIndex].Cells["VehicleId"].Value;

                // Delete the cargo vehicle from the database
                cargoVehicleRepo.DeleteVehicle(vehicleId);

                // Refresh data grid view
                LoadCargoVehicles();
            }

        }

        private void LoadCargoVehicles()
        {
            List<CargoVehicle> cargoVehicles = cargoVehicleRepo.GetAllVehicles();
            dgvVehicles.DataSource = cargoVehicles;
        }
    }
}
