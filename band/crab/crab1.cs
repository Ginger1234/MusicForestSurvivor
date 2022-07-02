
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(Animation))]
public class crab1 : MonoBehaviour {
	public Animation anim;
	AnimationClip animationClip;
     float timer = 0f;

 
	void Start () {
        anim = gameObject.GetComponent<Animation>();
        //anim["dead"].layer = 123;
	}
    void Update()
    {
        StartCoroutine( loopCrab());

        // leave spin or jump to complete before changing
      /*  if (anim.isPlaying)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            //Debug.Log("Spinning");
            anim.Play("dead");
        }*/
    }

    IEnumerator loopCrab()
    {
        if(timer <= 1)
        {
            //transform.Rotate(0f, Time.deltaTime*(-90), 0f);

            //yield return new WaitForSeconds(5);
            anim.CrossFade("walk");
            transform.Translate(Vector3.forward * 2f * Time.deltaTime);
            
            yield return null;

            timer += Time.deltaTime;
           // GetComponent<Animator>().SetFloat("WalkSpeed", 0f);
        }
        else if (timer<=2)
        {
            
            anim.CrossFade("knockout_earthfree");
            


           // yield return new WaitForSeconds(2);
           // anim.SetBool("tail", true);
            yield return null;

            timer += Time.deltaTime;
        }
     
        else 
        {
            //timer = 0f;
            
            
            //anim.SetBool("tail", false);
            yield return new WaitForSeconds(4);
            timer = 0f;
            
            yield return null;


        }
    }


}