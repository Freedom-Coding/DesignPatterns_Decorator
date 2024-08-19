using UnityEngine;

namespace DecoratorPattern
{
    public class SilencerDecorator : WeaponDecorator
    {
        public SilencerDecorator(IWeapon _wrappedWeapon) : base(_wrappedWeapon)
        {
            weaponData.shootingSound = Resources.Load<AudioClip>("ShootingSoundSilenced");
            weaponData.bulletPrefab = Resources.Load<GameObject>("BulletSilenced");
        }

        public override void Shoot()
        {
            base.Shoot();
        }
    }
}