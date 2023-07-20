using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour

{
    public LogicScript logic;
    public Animator animator;
    public Rigidbody2D ship;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        ship = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            animator.SetBool("player finished", true);
            ship.gravityScale = -1;
            
            logic.finish();


        }
    }
}
