using Humanizer;
using Problem_I.Interfaces;

namespace Problem_I.Services
{
    public class BicycleServices : IVehicle
    {
        public int NumberOfWheel { get; set; }

        public string GetNumberOfWheel() => NumberOfWheel.ToWords();

        public string Move() => "El vehículo se mueve con";

        public string StartEngine()
        {
            throw new NotImplementedException("Una bicicleta no tiene motor");
        }

        public string StopEngine()
        {
            throw new NotImplementedException("Una bicicleta no tiene motor");
        }
    }
}
