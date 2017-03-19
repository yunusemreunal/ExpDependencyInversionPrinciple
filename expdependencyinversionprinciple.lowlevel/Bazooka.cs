using System;
using ExpDependencyInversionPrinciple.Abstraction;

namespace ExpDependencyInversionPrinciple.LowLevel
{
    public class Bazooka : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Bazooka fired!");
        }

        public void Reload()
        {
            Console.WriteLine("Bazooka reloaded.");
        }
    }
}
