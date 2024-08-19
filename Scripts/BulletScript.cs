using UnityEngine;

namespace DecoratorPattern
{
    public class BulletScript : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody rb;

        private void OnEnable()
        {
            rb.velocity = transform.forward * speed;
            Destroy(gameObject, 5);
        }
    }
}