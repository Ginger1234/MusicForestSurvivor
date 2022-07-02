using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3 : MonoBehaviour
{
    [SerializeField] KeyCode keyOne; //vertical 
    [SerializeField] KeyCode keyTwo; //horizontal*/
    public float speed; 
    public float rotationSpeed;
    

   /* [SerializeField] Vector3 movement;
    [SerializeField] Vector3 Turn;*/

    int  direction;
    Animator anim;
    Rigidbody body;
    //int attackHash= Animator.StringToHash("Attack");

    

    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody>();
    }
    public void Attack(){
		anim.SetTrigger("Attack");
	}
	
	
	public void Eat(){
		anim.SetTrigger("Eat");
	}

	public void Death(){
		anim.SetTrigger("Death");
	}

	public void Move(float v,float h){
		anim.SetFloat ("Forward", Mathf.Abs(v));
		anim.SetFloat ("Turn", h);
	}
    private void FixedUpdate()
    {
        if (Input.GetButtonDown ("Fire1")) {
			Attack();
		}
        if (Input.GetKeyDown (KeyCode.E)) {
			Eat();
		}
        float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
        body.velocity = (transform.forward * v)*speed*Time.fixedDeltaTime;
        transform.Rotate((transform.up * h) * rotationSpeed * Time.fixedDeltaTime);
       /* Vector3 movement = new Vector3(h, 0, v);
        transform.Translate(movement * speed * Time.deltaTime);*/

		Move (v,h);
        /*if(Input.GetKey(KeyCode.W))
        {
            //ShuffleSound.Play(0);
            GetComponent<Rigidbody>().velocity+=movement;
            //GetComponent<Animator>().Controller;


        }
        if(Input.GetKey(KeyCode.S))
        {
            //this.transform.localPosition = new Vector3 (0f,0f,0.5f, Space.Self);
            //ShuffleSound.Play(0);
            GetComponent<Rigidbody>().velocity-=movement;

        }
        if(Input.GetKey(KeyCode.D))
        {
            //ShuffleSound.Play(0);
            this.transform.Rotate(0.0f, 0.5f,0.0f, Space.Self);
            movement.x+=0.005f;

        }
        if(Input.GetKey(KeyCode.A))
        {
            //ShuffleSound.Play(0);
            this.transform.Rotate(0.0f, -0.5f,0.0f, Space.Self);

        }*/

        /*if(Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger(attackHash);
        }|*/
        /*if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //ShuffleSound.Play(0);

        }*/
        /*if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

        }*/
    }
    // Update is called once per frame
  
}
