using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed;
    public Vector2 horizontalMove;
    public float jumpPower;
    public Animator animator;
    public LogicScript logic;
    public bool playerAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

       horizontalMove = new Vector2(Input.GetAxis("Horizontal"), 0).normalized;

        if (Input.GetKeyDown(KeyCode.Space) && playerAlive)
        {
            player.velocity = Vector2.up * jumpPower;
        }

        animator.SetFloat("speed", Mathf.Abs(horizontalMove.magnitude) * speed);

        bool flipped = horizontalMove.x < 0;
        player.transform.rotation = Quaternion.Euler(new Vector3(0, flipped ? 180 : 0, 0));

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag.Equals("Kill"))
        {
            animator.SetBool("player alive", false);
            logic.gameOver();
            playerAlive = false;
            
        }
        

    } 




    private void FixedUpdate()
    {
        if (horizontalMove != Vector2.zero && playerAlive)
        {
            var xMove = horizontalMove.x * speed * Time.deltaTime;
            player.transform.Translate(new Vector3(xMove, 0), Space.World);
        }
    }
}