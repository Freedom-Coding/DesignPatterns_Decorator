using UnityEngine;

namespace DecoratorPattern
{
    public interface IWeapon
    {
        WeaponData weaponData { get; set; }
        void Shoot();
    }

    public class WeaponData
    {
        readonly public Transform weaponTransform;
        public int maxAmmo;
        public int currentAmmo;
        public float effectiveRange;
        public float zoomFOV;
        public GameObject bulletPrefab;
        public AudioClip shootingSound;

        public WeaponData(Transform _weaponTransform)
        {
            weaponTransform = _weaponTransform;
        }
    }
}