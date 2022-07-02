using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog6 : MonoBehaviour
{
    // Start is called before the first frame update
    public float waitTime = 3;
    public float rotation = 70;

    void Start()
    {
        
    }

    // Update is called once per frame
    float timer = 0f;

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
            GetComponent<Animator>().SetFloat("WalkSpeed", 2f);
           // transform.Rotate(0f, Time.deltaTime*20, 0f);
            transform.Translate(Vector3.forward * 2f * Time.deltaTime);
            
            yield return null;

            timer += Time.deltaTime;
           // GetComponent<Animator>().SetFloat("WalkSpeed", 0f);
        }
        else if (timer<=2)
        {
            
            GetComponent<Animator>().SetBool("RightTurn", true);
            transform.Rotate(0f, Time.deltaTime*rotation, 0f);
           // transform.Rotate(0f, Time.deltaTime*20, 0f);
            //transform.Translate(Vector3.forward * 2f * Time.deltaTime);
            
            yield return null;

            timer += Time.deltaTime;
        }
        else 
        {
            //timer = 0f;
            
            GetComponent<Animator>().SetFloat("WalkSpeed", 0f);
            GetComponent<Animator>().SetBool("RightTurn", false);

            yield return new WaitForSeconds(waitTime);
            timer = 0f;
            
            yield return null;


        }
    }
}
