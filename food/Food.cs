using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Food : MonoBehaviour
{
   // Animator iguanaAnimator;
    //public GameObject eatingEffect;
    // Start is called before the first frame update
    
    public ParticleSystem foodPartickle;

    public Button eatButton;

    void Start()
    {
        eatButton = transform.FindChild("Canvas").FindChild("eat").GetComponent<Button>();
        eatButton.gameObject.SetActive(false);
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player"))
        {
           eatButton.gameObject.SetActive(true);
           GameObject player = GameObject.FindGameObjectWithTag("Player");
            InventorySystem inventory = player.gameObject.GetComponent<InventorySystem>();
            inventory.itemTmp = gameObject.GetComponent<PickItem >();
        }
        else 
        {
            eatButton.gameObject.SetActive(false);
           GameObject player = GameObject.FindGameObjectWithTag("Player");
            InventorySystem inventory = player.gameObject.GetComponent<InventorySystem>();
            inventory.itemTmp = null;
        
        }
    }

    public void Eating(){
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player playerScript = player.gameObject.GetComponent<player>();
        playerScript.Eat();
        foodPartickle.Play();
        //Instantiate(eatingEffect, transform.position, transform.rotation);
       
        Health PlayerHealth = player.gameObject.GetComponent<Health>();
        //Debug.Log(PlayerHealth.numOfHearts);
        PlayerHealth.numOfHearts +=1; 
        PlayerHealth.health +=1; 
       // Debug.Log(PlayerHealth.numOfHearts);
        //Debug.Log(PlayerHealth.health);
        StartCoroutine(Wait());
        
    }

     IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
         yield return null;
    }
}
