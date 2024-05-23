using Microsoft.Data.SqlClient;
using TransportationAccountingSystemWFA.Helpers;

namespace TransportationAccountingSystemWFA.Repositories.Implementations;

public class CargoVehicleRepository
{
    private string connectionString = "Server=DESKTOP-PEEVQ8J\\SQLEXPRESS;Database=VehiculeDb;Trusted_Connection=True;Encrypt=false;";
    private SqlConnection connection { get; set; }

    public CargoVehicleRepository()
    {
        connection = new SqlConnection(connectionString);
    }

    public void Connect()
    {
        try
        {
            connection.Open();
        }
        catch { throw; }
    }

    public void Close()
    {
        try { connection.Close(); }
        catch { throw; }
    }

    public List<CargoVehicle> GetAllVehicles()
    {
        List<CargoVehicle> vehicles = new List<CargoVehicle>();
        Connect();
        string request = "Select * from Vehiclee where CargoCapacity is not null";
        SqlCommand command = new SqlCommand(request, connection);
        var result = command.ExecuteReader();

        if (result.HasRows)
        {
            while (result.Read())
            {
                CargoVehicle vehicle = new CargoVehicle();
                vehicle.VehicleId = int.Parse(result["VehicleId"].ToString());
                vehicle.StateNumber = result["StateNumber"].ToString();
                vehicle.Model = int.Parse(result["Model"].ToString());
                vehicle.ReleaseDate = Convert.ToDateTime(result["ReleaseDate"]);
                vehicle.Mileage = int.Parse(result["Mileage"].ToString());
                vehicle.CargoCapacity = int.Parse(result["CargoCapacity"].ToString());
                vehicles.Add(vehicle);
            }
        }

        Close();
        return vehicles;
    }

    public void AddVehicle(CargoVehicle vehicle)
    {
        Connect();
        string request = "Insert into Vehiclee(StateNumber, Model, ReleaseDate, Mileage, CargoCapacity) values(@StateNumber, @Model, @ReleaseDate, @Mileage, @CargoCapacity)";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@StateNumber", vehicle.StateNumber);
        command.Parameters.AddWithValue("@Model", vehicle.Model);
        command.Parameters.AddWithValue("@ReleaseDate", vehicle.ReleaseDate);
        command.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
        command.Parameters.AddWithValue("@CargoCapacity", vehicle.CargoCapacity);
        command.ExecuteNonQuery();
        Close();
    }

    public void UpdateVehicle(CargoVehicle vehicle)
    {
        Connect();
        string request = "Update Vehiclee SET StateNumber = @StateNumber, Model = @Model, ReleaseDate = @ReleaseDate, Mileage = @Mileage, CargoCapacity = @CargoCapacity where VehicleId = @VehicleId";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@VehicleId", vehicle.VehicleId);
        command.Parameters.AddWithValue("@StateNumber", vehicle.StateNumber);
        command.Parameters.AddWithValue("@Model", vehicle.Model);
        command.Parameters.AddWithValue("@ReleaseDate", vehicle.ReleaseDate);
        command.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
        command.Parameters.AddWithValue("@CargoCapacity", vehicle.CargoCapacity);
        command.ExecuteNonQuery();
        Close();
    }

    public void DeleteVehicle(int id)
    {
        Connect();
        string request = "DELETE From Vehiclee where VehicleId = @VehicleId";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@VehicleId", id);
        command.ExecuteNonQuery();
        Close();
    }
}
