using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;


[RequireComponent(typeof(Animator), typeof(NavMeshAgent))]
public class frog4 : MonoBehaviour 
{

    private static int ANIMATOR_PARAM_WALK_SPEED = 
    	Animator.StringToHash("WalkSpeed");

    private Animator _animator;    
    private NavMeshAgent _agent;
    private bool canMove;
    public float speed = 2;
   private void Start()
    {
        canMove = true;
    }
     private void Awake() 
    {
        this._animator = this.GetComponent<Animator>();
        
       // this._agent = this.GetComponent<NavMeshAgent>();    
    }
    void Update()
    {
       // if (canMove)
        StartCoroutine(NPCMovement());
           

        // Moves the object forward at two units per second.
       /* _animator.SetFloat("WalkSpeed", speed);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);*/
    }
    IEnumerator NPCMovement()
    {
        //canMove=false;
        _animator.SetFloat("WalkSpeed", speed);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        yield return new WaitForSeconds(3f);
        _animator.SetBool("Jump",true);
        transform.Translate(Vector3.right * (speed+1) * Time.deltaTime);
        yield return new WaitForSeconds(2f);
        _animator.SetBool("Jump",false);
        _animator.SetFloat("WalkSpeed", 0);
        yield return 0;

       // canMove =true;
        
    }

/*
    private void Awake() 
    {
        canMove = true;
        this._animator = this.GetComponent<Animator>();
        this._agent = this.GetComponent<NavMeshAgent>();    
    }
    IEnumerator NPCMovement()
    {
        canMove=false;
        _animator.SetFloat("WalkSpeed", 2);
        transform.TransformDirection(Vector3.forward);
        //transform.position = new Vector3(0,0,2) * Time.deltaTime; 
        yield return new WaitForSeconds(5f);

        canMove=true;
        
    }
    private void Update()
    {

        if(canMove == true)
        {
            StartCoroutine(NPCMovement());
        }
    
    }
*/

 
}