using Enumerations;
using NonMotorizedVehicles;

namespace Structures
{
    public struct Tricycle : INonMotorizedVehicle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get; set; }
        public int NoOfWheels { get; set; }
        public bool Moving()
        {
            return Moving();
        }
        public bool Moving(bool isMoving)
        {
            return Moving(isMoving);

        }
    }

    //added bicycle struct
    public struct Bicycle : INonMotorizedVehicle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get; set; }
        public int NoOfWheels { get; set; }
        public bool Moving()
        {
            return Moving();
        }
        public bool Moving(bool isMoving)
        {
            return Moving(isMoving);
        }

    }
}
