using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float destroyTime;



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
        Destroy(gameObject) ;
        
    }


    IEnumerator waiter()
    {
        yield return new WaitForSeconds(destroyTime);
        Object.Destroy(gameObject); 
    }


}
