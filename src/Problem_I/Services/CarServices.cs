using Humanizer;
using Problem_I.Interfaces;

namespace Problem_I.Services
{
    public class CarServices : IVehicle
    {
        public int NumberOfWheel { get; set; }

        public string GetNumberOfWheel() => NumberOfWheel.ToWords();

        public string Move() => "el vehículo se mueve con";

        public string StartEngine() => "enciende el motor";

        public string StopEngine() => "apaga el motor";
    }
}
