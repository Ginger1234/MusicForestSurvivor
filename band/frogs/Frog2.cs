using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog2 : MonoBehaviour
{
    // Start is called before the first frame update
   private Rigidbody npc; // If the script is on you NPC this will be okay
    //If not, consider serializing the field or making it public.
    private bool canMove;

    Animator anim;

    
    private void Start()
    {
        npc = GetComponent<Rigidbody>();
        canMove = true;
        anim = GetComponent<Animator>();
    }

    IEnumerator NPCMovement()
    {
        canMove=false;
        MoveLeft();
        yield return new WaitForSeconds(5f);
        MoveUp();
        yield return new WaitForSeconds(5f);
        canMove=true;
    }
    
    private void Update()
    {
    // You will call your functions here.
    // However, you want to define your conditions of movement
    // in perhaps an IENumerator or use ray casting.
    
    // if your raycast detects a wall, make your enemy change direction
    
    // otherwise, if your NPC is freeroam you can use an IENumerator
    // to let it move for a certain amount of time then change direction.
    
    if(canMove == true)
    {
    StartCoroutine(NPCMovement());
    }
    
    }
    
    void MoveLeft()
    {
    anim.SetTrigger("Crawl");

    npc.velocity = Vector3.left*10;
    //Include you animation and other relevant sequences here
    }

    void MoveUp()
    {
    anim.SetTrigger("Jump");

    npc.velocity = Vector3.up*3;
    //Include you animation and other relevant sequences here
    }
    
    void MoveRight()
    {
    npc.velocity = Vector3.right*10;
    //Include you animation and other relevant sequences here
    }

    
}
