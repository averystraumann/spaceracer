using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAlien : MonoBehaviour
{

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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
                animator.SetBool("alive", false);
                Destroy(gameObject, 0.3f);
                Destroy(collision.gameObject);
            }

        }
    }
    
}
