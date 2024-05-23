using Microsoft.Data.SqlClient;
using TransportationAccountingSystemWFA.Helpers;

namespace TransportationAccountingSystemWFA.Repositories.Implementations;

public class PassengerVehicleRepository
{
    private string connectionString = "Server=DESKTOP-PEEVQ8J\\SQLEXPRESS;Database=VehiculeDb;Trusted_Connection=True;Encrypt=false;";
    private SqlConnection connection;

    public PassengerVehicleRepository()
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

    public List<PassengerVehicle> GetAllVehicles()
    {
        List<PassengerVehicle> vehicles = new List<PassengerVehicle>();
        Connect();
        string request = "SELECT * FROM Vehiclee WHERE PassengerCapacity IS NOT NULL";
        SqlCommand command = new SqlCommand(request, connection);
        var result = command.ExecuteReader();

        if (result.HasRows)
        {
            while (result.Read())
            {
                PassengerVehicle vehicle = new PassengerVehicle
                {
                    VehicleId = int.Parse(result["VehicleId"].ToString()),
                    StateNumber = result["StateNumber"].ToString(),
                    Model = int.Parse(result["Model"].ToString()),
                    ReleaseDate = Convert.ToDateTime(result["ReleaseDate"]),
                    Mileage = int.Parse(result["Mileage"].ToString()),
                    PassengerCapacity = int.Parse(result["PassengerCapacity"].ToString())
                };
                vehicles.Add(vehicle);
            }
        }

        Close();
        return vehicles;
    }

    public void AddVehicle(PassengerVehicle vehicle)
    {
        Connect();
        string request = "INSERT INTO Vehiclee (StateNumber, Model, ReleaseDate, Mileage, PassengerCapacity) VALUES (@StateNumber, @Model, @ReleaseDate, @Mileage, @PassengerCapacity)";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@StateNumber", vehicle.StateNumber);
        command.Parameters.AddWithValue("@Model", vehicle.Model);
        command.Parameters.AddWithValue("@ReleaseDate", vehicle.ReleaseDate);
        command.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
        command.Parameters.AddWithValue("@PassengerCapacity", vehicle.PassengerCapacity);
        command.ExecuteNonQuery();
        Close();
    }

    public void UpdateVehicle(PassengerVehicle vehicle)
    {
        Connect();
        string request = "UPDATE Vehiclee SET StateNumber = @StateNumber, Model = @Model, ReleaseDate = @ReleaseDate, Mileage = @Mileage, PassengerCapacity = @PassengerCapacity WHERE VehicleId = @VehicleId";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@VehicleId", vehicle.VehicleId);
        command.Parameters.AddWithValue("@StateNumber", vehicle.StateNumber);
        command.Parameters.AddWithValue("@Model", vehicle.Model);
        command.Parameters.AddWithValue("@ReleaseDate", vehicle.ReleaseDate);
        command.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
        command.Parameters.AddWithValue("@PassengerCapacity", vehicle.PassengerCapacity);
        command.ExecuteNonQuery();
        Close();
    }

    public void DeleteVehicle(int id)
    {
        Connect();
        string request = "DELETE FROM Vehiclee WHERE VehicleId = @VehicleId";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@VehicleId", id);
        command.ExecuteNonQuery();
        Close();
    }
}
