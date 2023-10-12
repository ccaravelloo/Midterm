using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class CooperDriver : Driver
    {
        public CooperDriver(RaceCar car) : base(car)
        {
            Name = "CooperDriver";
            SkillLevel = 20;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
