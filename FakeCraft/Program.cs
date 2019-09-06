﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCraft
{
    class Program
    {
        static Random _random = new Random();
          
        
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Marine());
            units.Add(new Marine());
            units.Add(new Firebat());
            units.Add(new Zealot());

            for (int i = 0; i < units.Count; i++)
                units[i].Dead += Unit_Dead;

            for (int i = 0; i < units.Count; i++)
                TakeRandomDamage(units[i]);
        }

        private static void Unit_Dead(object sender, Unit.DeadEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void TakeRandomDamage(Unit unit)
        {
            //unit.TakeDamage(_random.Next(1, 5));
            unit.TakeMultipleDamages(_random.Next(1, 5), _random.Next(1, 5), _random.Next(1, 5));

            Console.WriteLine(unit.ToText());
        }
    }
}
