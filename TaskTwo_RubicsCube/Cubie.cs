using static TaskTwo_RubicsCube.Cube;

namespace TaskTwo_RubicsCube
{
    public class Cubie
    {
        public CubieFace Front { get; set; }
        public CubieFace Back { get; set; }
        public enum CubieFace
        {
            White,
            Red,
            Green,
            Blue,
            Orange,
            Yellow
        }
        public enum RotationDirection
        {
            ClockWise,
            CounterClockWise
        }
    }
}