using UnityEngine;
using Cinemachine;

namespace DecoratorPattern
{
    public class PistolController : MonoBehaviour
    {
        [SerializeField] private PistolUpgrader pistolUpgrader;
        [SerializeField] private CinemachineVirtualCamera weaponZoomCamera;

        private IWeapon weapon;
        private bool isZoomed;

        private void Start()
        {
            weapon = pistolUpgrader.weapon;
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                weapon.Shoot();
            }
            if (Input.GetMouseButtonDown(1))
            {
                if (isZoomed)
                {
                    isZoomed = false;
                    weaponZoomCamera.Priority = 0;
                }
                else
                {
                    isZoomed = true;
                    weaponZoomCamera.m_Lens.FieldOfView = weapon.weaponData.zoomFOV;
                    weaponZoomCamera.Priority = 15;
                }
            }
        }
    }
}
