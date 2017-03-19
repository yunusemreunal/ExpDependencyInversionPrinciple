using System;
using ExpDependencyInversionPrinciple.Abstraction;

namespace ExpDependencyInversionPrinciple.LowLevel
{
    public class Rifle : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Rifle fired!");
        }

        public void Reload()
        {
            Console.WriteLine("Rifle reloaded.");
        } 
    }
}