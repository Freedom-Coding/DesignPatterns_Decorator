using UnityEngine;

namespace DecoratorPattern
{
    public class Pistol : IWeapon
    {
        public WeaponData weaponData { get; set; }

        public Pistol(Transform _pistolTransform)
        {
            weaponData = new WeaponData(_pistolTransform);
            weaponData.maxAmmo = 10;
            weaponData.currentAmmo = 10;
            weaponData.effectiveRange = 500;
            weaponData.zoomFOV = 32;
            weaponData.shootingSound = Resources.Load<AudioClip>("ShootingSound");
            weaponData.bulletPrefab = Resources.Load<GameObject>("BulletBase");
        }

        public void Shoot()
        {
            Debug.Log($"Shooting a pistol with {weaponData.maxAmmo} max ammo, {weaponData.currentAmmo} current ammo, " +
                $"{weaponData.effectiveRange} effective range and {weaponData.shootingSound.name} shooting sound.");

            AudioPlayer.Instance.Play(weaponData.shootingSound);
            GameObject.Instantiate(weaponData.bulletPrefab, weaponData.weaponTransform.position, weaponData.weaponTransform.rotation);
        }
    }
}