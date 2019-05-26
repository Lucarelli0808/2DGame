using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{

    public float speed;
    public float jumps;
    bool isJumping;
    Rigidbody2D rg;
	
	GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
	   gm = GameObject.Find("GameManager").GetComponent<GameManager> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rg.velocity = new Vector2(speed * move, rg.velocity.y);
        Jump();
    }

	void OnTriggerEnter2D(Collider2D other)
	
    {
	if(other.tag == "Coin")

    	{
        gm.CoinsCollected();
	   Destroy(other.gameObject);
   	 }

        
    }


    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && !isJumping)
        {
            isJumping = true;
            rg.AddForce(new Vector2(rg.velocity.x, jumps));
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;

            rg.velocity = Vector2.zero;
        }
    }
}
