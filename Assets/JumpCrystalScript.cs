using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCrystalScript : MonoBehaviour
{

    public PlayerScript playerScript;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag.Equals("Player")) {
            playerScript.jumpCrystal = true;
            Destroy(gameObject);
         
      }
    }

     IEnumerator waiter(float seconds) {
        yield return new WaitForSeconds(seconds);
    }
}
