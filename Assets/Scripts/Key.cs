using UnityEngine;

namespace LabyrintheUnity
{
    public class Key : MonoBehaviour
    {
   
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("player"))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
