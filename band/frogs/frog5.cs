using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog5 : MonoBehaviour
{
    private Animator _animator; 
    public float speed = 2;


    // Start is called before the first frame update
   void Start() 
   {
        this._animator = this.GetComponent<Animator>();

        StartCoroutine(UpdateLoop());
    }
    
    IEnumerator UpdateLoop() {
       
            _animator.SetFloat("WalkSpeed", speed);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            yield return new WaitForSeconds(6f);
             yield return null;
        
    } 
}
