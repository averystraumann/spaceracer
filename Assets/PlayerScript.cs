using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed;
    public Vector2 horizontalMove;
    public float jumpPower = 14;
    public Animator animator;
    public LogicScript logic;
    public bool playerAlive = true;
    public Transform groundChecker;
    public bool onGround;
    public float groundCheckerRadius;
    public LayerMask groundLayer;
    public bool jumpCrystal = false;
    public float jcBoostTimer = 0;


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

       bool onGround = Physics2D.OverlapCircle(groundChecker.position, groundCheckerRadius, groundLayer);

        if (jumpCrystal) {
            animator.SetBool("jump boost", true);
            jumpPower = 20;
            jcBoostTimer += Time.deltaTime;
            if  (jcBoostTimer > 5) {
                jumpPower = 14;
                jumpCrystal = false;
                animator.SetBool("jump boost", false);
                jcBoostTimer = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && playerAlive && onGround)
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
            Destroy(gameObject, 3f);
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
