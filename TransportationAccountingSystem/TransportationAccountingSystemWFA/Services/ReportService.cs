using Microsoft.Data.SqlClient;
using TransportationAccountingSystemWFA.Helpers;

namespace TransportationAccountingSystemWFA.Services;

public class ReportService
{
    private string connectionString = "Server=DESKTOP-PEEVQ8J\\SQLEXPRESS;Database=VehiculeDb;Trusted_Connection=True;Encrypt=false;";
    private SqlConnection connection;

    public ReportService()
    {
        connection = new SqlConnection(connectionString);
    }

    public void Connect()
    {
        try
        {
            connection.Open();
        }
        catch
        {
            throw;
        }
    }

    public void Close()
    {
        try
        {
            connection.Close();
        }
        catch
        {
            throw;
        }
    }

    public List<VehicleReport> GenerateVehicleReport(DateTime startDate, DateTime endDate)
    {
        Connect();
        string request = @"
            SELECT v.VehicleId, v.StateNumber, SUM(r.Distance) AS TotalMileage, SUM(r.Volume) AS TotalVolume, SUM(r.PassengerCount) AS TotalPassengers
            FROM Vehiclee v
            LEFT JOIN Route r ON v.VehicleId = r.VehicleId
            WHERE r.Date >= @StartDate AND r.Date <= @EndDate
            GROUP BY v.VehicleId, v.StateNumber";

        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@StartDate", startDate);
        command.Parameters.AddWithValue("@EndDate", endDate);
        var result = command.ExecuteReader();

        List<VehicleReport> vehicleReports = new List<VehicleReport>();
        if (result.HasRows)
        {
            while (result.Read())
            {
                VehicleReport report = new VehicleReport
                {
                    VehicleId = int.Parse(result["VehicleId"].ToString()),
                    StateNumber = result["StateNumber"].ToString(),
                    TotalMileage = result["TotalMileage"] != DBNull.Value ? int.Parse(result["TotalMileage"].ToString()) : 0,
                    TotalVolume = result["TotalVolume"] != DBNull.Value ? int.Parse(result["TotalVolume"].ToString()) : 0,
                    TotalPassengers = result["TotalPassengers"] != DBNull.Value ? int.Parse(result["TotalPassengers"].ToString()) : 0
                };
                vehicleReports.Add(report);
            }
        }

        Close();
        return vehicleReports;
    }

    public List<DestinationReport> GenerateDestinationReport(string destination, DateTime startDate, DateTime endDate)
    {
        Connect();
        string request = @"
            SELECT r.Date, r.Volume, r.PassengerCount
            FROM Route r
            INNER JOIN City c ON r.ToCityId = c.Id
            WHERE c.Name = @Destination AND r.Date >= @StartDate AND r.Date <= @EndDate";

        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@Destination", destination);
        command.Parameters.AddWithValue("@StartDate", startDate);
        command.Parameters.AddWithValue("@EndDate", endDate);
        var result = command.ExecuteReader();

        List<DestinationReport> destinationReports = new List<DestinationReport>();
        if (result.HasRows)
        {
            while (result.Read())
            {
                DestinationReport report = new DestinationReport
                {
                    Date = Convert.ToDateTime(result["Date"]),
                    Volume = result["Volume"] != DBNull.Value ? int.Parse(result["Volume"].ToString()) : 0,
                    PassengerCount = result["PassengerCount"] != DBNull.Value ? int.Parse(result["PassengerCount"].ToString()) : 0
                };
                destinationReports.Add(report);
            }
        }

        Close();
        return destinationReports;
    }
}
