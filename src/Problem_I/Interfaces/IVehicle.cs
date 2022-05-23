namespace Problem_I.Interfaces
{
    public interface IVehicle
    {
        public int NumberOfWheel { get; set; }
        string GetNumberOfWheel();
        string Move();
        string StartEngine();
        string StopEngine();
    }
}
