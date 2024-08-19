namespace DecoratorPattern
{
    public class ScopeDecorator : WeaponDecorator
    {
        public ScopeDecorator(IWeapon _wrappedWeapon) : base(_wrappedWeapon)
        {
            weaponData.effectiveRange += 200;
            weaponData.zoomFOV -= 10;
        }

        public override void Shoot()
        {
            base.Shoot();
        }
    }
}