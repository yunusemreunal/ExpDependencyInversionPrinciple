using ExpDependencyInversionPrinciple.Abstraction;
using ExpDependencyInversionPrinciple.HighLevel;
using ExpDependencyInversionPrinciple.LowLevel;
using Microsoft.Win32;

namespace ExpDependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            UseBazooka();
        }

        private static void UseBazooka()
        {

            IWeapon weapon = new Bazooka();

            var player = new Player(weapon);

            player.Shoot();
            player.Reload();
        }

        private static void UseRifle()
        {
            IWeapon weapon = new Rifle();

            var player = new Player(weapon);

            player.Shoot();
            player.Reload();
        }
    }
}
