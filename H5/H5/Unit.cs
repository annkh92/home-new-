using System;
using System.Collections.Generic;
using System.Text;


namespace H5
{
    abstract class Unit
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int HealthPoint { get; set; }

        public abstract void Action();

        public void GetInfo()
        {
            Console.WriteLine($"Вы создали отряд: {Name}. Его сила = {AttackPower}. Здоровье: {HealthPoint} единиц");
        }
    }
}
