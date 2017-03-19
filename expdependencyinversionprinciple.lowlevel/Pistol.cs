
using System;
using ExpDependencyInversionPrinciple.Abstraction;

namespace ExpDependencyInversionPrinciple.LowLevel
{
    public class Pistol : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Pistol fired!");
        }

        public void Reload()
        {
            Console.WriteLine("Pistol reloaded");
        }
    }
}
