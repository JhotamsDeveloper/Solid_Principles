using Humanizer;
using Soluction_I.Interfaces;

namespace Soluction_I.Services
{
    public class CarServices : ICar
    {
        public int NumberOfWheel { get; set; }

        public string GetNumberOfWheel() => NumberOfWheel.ToWords();

        public string Move() => "el vehículo se mueve con";

        public string StartEngine() => "puede enciender un motor";

        public string StopEngine() => "puede apagar un motor";
    }
}
