using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    CharacterController _characterController;
    public float speed;
    public float RunSpeed;
    public float speed_rotation;
    public float jumpSpeed=10;
   
    Animator anim;
    float gravity= 10;
    //public AudioSource[] instruments;
    public List<AudioSource> instruments = new List<AudioSource>();

    public bool foodTrue = false;

    



    // Start is called before the first frame update
    void Start()
    {
         for (int i=0; i<instruments.Count; i++)
        {
            instruments[i].Play();
        }
        _characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        //body = GetComponent<Rigidbody>();
    }



    public void Attack(){
		anim.SetTrigger("Attack");
	}
	
	
	public void Eat(){
        if (foodTrue)
		    anim.SetTrigger("Eat");
	}

	public void Death(){
		anim.SetTrigger("Death");
	}


	public void Move(float v,float h){
        anim.SetFloat ("Forward", Mathf.Abs(v));
        anim.SetFloat("Speed", Mathf.Abs(v) );
	    anim.SetFloat ("Turn", h);
		
	}
    private void FixedUpdate()
    {
        if (Input.GetButtonDown ("Fire1")) {
			Attack();
		}
       /* if (Input.GetKeyDown (KeyCode.E)) {
			Eat();
		}*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal")*speed_rotation,0);
        Vector3 forward;
        float curSpeed= speed * Input.GetAxis("Vertical");
        forward = transform.TransformDirection(Vector3.forward);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            curSpeed = RunSpeed * Input.GetAxis("Vertical");
        }
        if (_characterController.isGrounded)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log(forward);
                forward.y = jumpSpeed;
                Debug.Log(forward);
                
            }
        }
        forward.y -= gravity * Time.deltaTime;

        _characterController.Move(forward * curSpeed*Time.deltaTime); 
        float h = Input.GetAxis ("Horizontal");
		//float v = Input.GetAxis ("Vertical");
       // Physics.SyncTransforms;
        Move (curSpeed,h);



        //Physics.gravity = Vector3(0, -30, 0);
 
        /*if(Input.GetKey("space"))
        {
        jumped = true;
        jumpSpeed = 5;
        }
        
        if(jumped)
        {
        if(jumpSpeed > 0)
        {
        jumpSpeed -= 5*Time.deltaTime;
        }
        else
        {
        jumped = false;
        }
        
        transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
        }*/
    }
}
