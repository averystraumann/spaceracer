using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CherryCollection : MonoBehaviour
{
    public Object thisObj;
    public Animator animator;

    public void Awake() {
        thisObj = GetComponent<Object>();
    }

    public void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag.Equals("Player")) {
            animator.SetBool("cherryCollected", true);
            Destroy(thisObj);
        }
    }
}
