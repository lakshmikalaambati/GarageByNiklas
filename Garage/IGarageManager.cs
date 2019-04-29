namespace MyGarage
{
    interface IGarageManager
    {
        Garage<Vehicle> Garage { get; }

        bool DriveOut(string regNum);
        Vehicle FindVehicleByRegNum(string regNum);
        Vehicle[] FindVehicleByString(string keyword);
        Vehicle[] FindVehicleByType(string type);
        string[] GetAllSpaces();
        string[] GetAllVehicles();
        string GetStatistics();
        bool HasFreeSpace();
        void LoadGarage();
        bool ParkVehicle(Vehicle vehicle);
        void SaveGarage();
        void AddSize(int size);
    }
}