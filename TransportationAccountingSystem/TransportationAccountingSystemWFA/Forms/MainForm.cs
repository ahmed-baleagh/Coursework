using TransportationAccountingSystemWFA.Helpers;
using TransportationAccountingSystemWFA.Services;

namespace TransportationAccountingSystemWFA.Forms
{
    public partial class MainForm : Form
    {
        private ReportService reportService;
        public MainForm()
        {
            InitializeComponent();
            reportService = new ReportService();
        }

        private void btnGenerateVehicleReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            List<VehicleReport> vehicleReports = reportService.GenerateVehicleReport(startDate, endDate);

            dataGridView.DataSource = vehicleReports;
        }

        private void btnGenerateDestinationReport_Click(object sender, EventArgs e)
        {
            string destination = txtDestination.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            List<DestinationReport> destinationReports = reportService.GenerateDestinationReport(destination, startDate, endDate);

            dataGridView.DataSource = destinationReports;
        }

        private void cargoPassengerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of CargoPassengerVehicleForm
            CargoPassengerVehicleForm cargoPassengerVehicleForm = new CargoPassengerVehicleForm();

            // Show the form
            cargoPassengerVehicleForm.Show();
        }

        private void cargoVehicleFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargoVehicleForm cargoVehicleForm = new CargoVehicleForm();

            cargoVehicleForm.Show();
        }

        private void passenegerVehicleformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassengerVehicleForm passengerVehicleForm = new PassengerVehicleForm();
            passengerVehicleForm.Show();
        }
    }
}
