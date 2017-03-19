using ExpDependencyInversionPrinciple.Abstraction;

namespace ExpDependencyInversionPrinciple.HighLevel
{
   public  class Player
   {

       private readonly IWeapon _weapon;
       public Player(IWeapon weapon)
       {
           _weapon = weapon;
       }

       public void Shoot()
       {
           _weapon.Shoot();
       }

       public void Reload()
       {
           _weapon.Reload();
       }

        #region "Without DIP"
        
       //public Pistol Pistol { get; set; }
       //public Rifle Rifle { get; set; }
       //public Bazooka Bazooka { get; set; }
       //public WeaponTypes WeaponType { get; set; }

       //public void Shoot()
       //{
       //    switch (WeaponType)
       //    {
       //        case WeaponTypes.Pistol:
       //            Pistol.Shoot();
       //            break;
       //        case  WeaponTypes.Rifle:
       //            Rifle.Shoot();
       //            break;
       //        case  WeaponTypes.Bazooka:
       //            Bazooka.Shoot();
       //            break;
       //    }
       //}

       //public void Reload()
       //{
       //    switch (WeaponType)
       //    {
       //        case WeaponTypes.Pistol:
       //            Pistol.Reload();
       //            break;
       //        case WeaponTypes.Rifle:
       //            Rifle.Reload();
       //            break;
       //        case WeaponTypes.Bazooka:
       //            Bazooka.Reload();
       //            break;
       //    }
       //}

       //public enum WeaponTypes
       //{
       //    Pistol,
       //    Rifle,
       //    Bazooka
        //}
        #endregion

    }
}
