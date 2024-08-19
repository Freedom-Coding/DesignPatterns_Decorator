namespace DecoratorPattern
{
    public abstract class WeaponDecorator : IWeapon
    {
        public WeaponData weaponData { get; set; }

        protected IWeapon wrappedWeapon;

        public WeaponDecorator(IWeapon _wrappedWeapon)
        {
            wrappedWeapon = _wrappedWeapon;
            weaponData = wrappedWeapon.weaponData;
        }

        public virtual void Shoot()
        {
            wrappedWeapon.Shoot();
        }
    }
}