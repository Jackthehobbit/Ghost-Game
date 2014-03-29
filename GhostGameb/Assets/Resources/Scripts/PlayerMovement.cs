 using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float maxSpeed = 29f;
	private float walkAcceleration = 10;
	public 	bool facingRight = true;
	Animator anim;
	public Transform groundCheck;
	public bool grounded = false;
	float groundRadius = 1f;
	public LayerMask whatisGround;
	public float jumpForce = 700f;
	private Vector3 MousePosition;
	public float walkdeceleration = 1.05f;
	private float walkdecelerationVolx;
	public float horizontalmovement;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();


			
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle(groundCheck.position,groundRadius,whatisGround);


		anim.SetBool("Ground",grounded);
		anim.SetFloat("VSpeed",rigidbody2D.velocity.y);
		float move = Input.GetAxis("Horizontal");
	
		anim.SetFloat("Speed",Mathf.Abs(move));//ABS= doesnt matter neg or positive

		rigidbody2D.velocity = new Vector2(move*walkAcceleration, rigidbody2D.velocity.y);
		
			

		
		horizontalmovement = Mathf.Abs(rigidbody2D.velocity.x);

		if( horizontalmovement > maxSpeed)
		{

			horizontalmovement = maxSpeed;
		}
	
		if( MousePosition.x > groundCheck.position.x
		   && !facingRight)
		{
			Flip();

		}

			else if(MousePosition.x < groundCheck.position.x && facingRight)
		{
			Flip();
		
		}
		if(grounded && Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetBool("Ground",false);
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
		}
		}
	void Update()

	{
		MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			if( MousePosition.x > groundCheck.position.x
		   && !facingRight)
		{
			Flip();

		}

			else if(MousePosition.x < groundCheck.position.x && facingRight)
		{
			Flip();
		
		}

	}

		void Flip()
	{
		if(Time.timeScale !=0)
		{
	facingRight= !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		}
	
	}

}