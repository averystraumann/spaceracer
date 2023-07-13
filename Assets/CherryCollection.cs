using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CherryCollection : MonoBehaviour
{
    public Object thisObj;
    public Animator animator;
    public bool cherryDied;
    public LogicScript logic;

    public void Start() {
        animator = GetComponent<Animator>();
    }

    public void Awake() {
        thisObj = GetComponent<Object>();
    }



    public void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag.Equals("Player")) {
            logic.cherryCount++;
            animator.SetBool("cherryCollected", true);
            Destroy(gameObject, 0.6f);
        }
    }
}