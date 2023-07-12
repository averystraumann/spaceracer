using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public class BulletScript : MonoBehaviour
    {
        public float speed;
        public Rigidbody2D rb;
        



        private void Awake()
        {
            StartCoroutine(waiter());
        }


        void Start()
        {
            rb.velocity = transform.right * speed;
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(gameObject);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);

        }


        IEnumerator waiter()
        {
            yield return new WaitForSeconds(1.2f);
            Object.Destroy(gameObject);
        }


    }
}
