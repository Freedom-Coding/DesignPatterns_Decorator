namespace DecoratorPattern
{
    public class LaserDecorator : WeaponDecorator
    {
        public LaserDecorator(IWeapon _wrappedWeapon) : base(_wrappedWeapon)
        {
            weaponData.effectiveRange += 150;
            weaponData.zoomFOV -= 4;
        }

        public override void Shoot()
        {
            base.Shoot();
        }
    }
}