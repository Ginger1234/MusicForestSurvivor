using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chomper1 : MonoBehaviour
{
     float timer = 0f;
     public float rotAngle;
    // public float moveSec;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim =  GetComponent<Animator>();
    }

    

    void Update()
    {
        
           StartCoroutine( loopRotation());
    // Time.deltaTime*100 will make sure we are moving at a constant speed of 100 per second
            //transform.Rotate(0f, Time.deltaTime*20, 0f);
    // Increment the timer so we know when to stop
      
    }

    IEnumerator loopRotation()
    {
        if(timer <= 1)
        {
            //yield return new WaitForSeconds(5);
           // anim.SetFloat("WalkSpeed", 2f);
            transform.Rotate(0f, Time.deltaTime*rotAngle, 0f);
            yield return new WaitForSeconds(2);
            //transform.Translate(Vector3.forward * moveSec * Time.deltaTime);
            
            yield return null;

            timer += Time.deltaTime;
           // GetComponent<Animator>().SetFloat("WalkSpeed", 0f);
        }
       
        else 
        {
            //timer = 0f;
            
            //anim.SetFloat("WalkSpeed", 0f);
           // anim.SetBool("jump", false);
            //anim.SetBool("tail", false);
            yield return new WaitForSeconds(3);
            timer = 0f;
            
            yield return null;


        }
    }
}
