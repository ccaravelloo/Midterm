using System;


namespace RaceTrack.RaceTrack.Cars
{
    public class Cooper : RaceCar
    {
        public Cooper()
        {
            Name = "Cooper";
            TopSpeed = 75;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Name}'s engine is started.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }

    }
}
