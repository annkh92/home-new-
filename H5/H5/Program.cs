using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace H5
{
    class Program
    {
        static void Main(string[] args)
        {

            Worker w = new Worker();
            Warrior d = new Warrior();
            Healer h = new Healer();

            w.GetInfo();
            w.Action();
            d.GetInfo();
            d.Action();
            h.GetInfo();
            h.Action();

            List<Unit> u = new List<Unit>();

            u.Add(new Worker());
            u.Add(new Warrior());
            u.Add(new Healer());
            u.Sort((a, b)=> a.AttackPower > b.AttackPower ? 1: -1);




        }
    }
}
