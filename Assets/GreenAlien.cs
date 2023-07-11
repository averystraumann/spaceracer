using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAlien : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.collider.CompareTag("bullet"))
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }

        }
    }
    
}
