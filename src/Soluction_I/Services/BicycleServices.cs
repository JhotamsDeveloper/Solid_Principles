using Humanizer;
using Soluction_I.Interfaces;

namespace Soluction_I.Services
{
    public class BicycleServices : IBicycle
    {
        public int NumberOfWheel { get; set; }

        public string GetNumberOfWheel() => NumberOfWheel.ToWords();

        public string Move() => "el vehículo se mueve con";
    }
}
