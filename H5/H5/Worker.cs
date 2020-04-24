using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    class Worker : Unit 
    {
        public Worker ()
        {
            Name =  "Рабочий";
            AttackPower = 0;
            HealthPoint = 5;
         }
        public override void Action()
        {
            Console.WriteLine("Рабочий занимается строительствои и сбором ресурсов");
        }

    }
}
