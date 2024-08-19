using UnityEngine;
using UnityEngine.UI;

namespace DecoratorPattern
{
    public class PistolUpgrader : MonoBehaviour
    {
        [SerializeField] private Button silencerUpgradeButton;
        [SerializeField] private Button laserUpgradeButton;
        [SerializeField] private Button scopeUpgradeButton;

        [SerializeField] private GameObject silencerGameObject;
        [SerializeField] private GameObject laserGameObject;
        [SerializeField] private GameObject scopeGameObject;

        [SerializeField] private Transform pistolTransform;

        public IWeapon weapon;

        private void OnEnable()
        {
            weapon = new Pistol(pistolTransform);

            silencerUpgradeButton.onClick.AddListener(AddSilencer);
            scopeUpgradeButton.onClick.AddListener(AddScope);
            laserUpgradeButton.onClick.AddListener(AddLaser);
        }

        private void AddSilencer()
        {
            weapon = new SilencerDecorator(weapon);
            silencerGameObject.SetActive(true);
            silencerUpgradeButton.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            silencerUpgradeButton.onClick.RemoveAllListeners();
        }

        private void AddScope()
        {
            weapon = new ScopeDecorator(weapon);
            scopeGameObject.SetActive(true);
            scopeUpgradeButton.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            scopeUpgradeButton.onClick.RemoveAllListeners();
        }

        private void AddLaser()
        {
            weapon = new LaserDecorator(weapon);
            laserGameObject.SetActive(true);
            laserUpgradeButton.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            laserUpgradeButton.onClick.RemoveAllListeners();
        }
    }
}