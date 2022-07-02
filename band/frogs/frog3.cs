using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog3 : MonoBehaviour
{
    CharacterController _characterController;
    public float speed;
    public float RunSpeed;
    public float speed_rotation;
    Animator anim;
    //public AudioSource[] instruments;
   // public List<AudioSource> instruments = new List<AudioSource>();




    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        //body = GetComponent<Rigidbody>();
    }
    public void Jump()
    {
        //RootMotion();
        anim.SetTrigger("Jump");
    }


	public void Crawl(float v,float h){
        anim.SetFloat ("Crawl", Mathf.Abs(v));
        anim.SetFloat("Speed", Mathf.Abs(v) );
	    anim.SetFloat ("Turn", h);
		
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
        
        _characterController.SimpleMove(forward * curSpeed); 
        float h = Input.GetAxis ("Horizontal");
		//float v = Input.GetAxis ("Vertical");
        Crawl (curSpeed,h);
    }
}
