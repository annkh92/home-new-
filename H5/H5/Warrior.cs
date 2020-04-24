using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    class Warrior : Unit

    {
        public Warrior ()
        {
            Name = "Воин";
            AttackPower = 3;
            HealthPoint = 7;
        }
        public override void Action()
        {
            Console.WriteLine("Воин принимает участие в сражении");
        }
    }
}
