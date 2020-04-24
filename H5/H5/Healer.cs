using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    class Healer : Unit

    {
        public Healer ()
        {
            Name = "Целитель";
            AttackPower = 2;
            HealthPoint = 6;
        }
        public override void Action()
        {
            Console.WriteLine("Целитель лечит союзные войска");
        }
    }
}
