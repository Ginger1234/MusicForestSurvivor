using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog1 : MonoBehaviour
{

    public GameObject frog;
    public GameObject frogsBody;
    Rigidbody m_Rigidbody;
    float m_Speed;
    
    //CharacterController controller;

    SkinnedMeshRenderer skinnedMeshRenderer;

    Animator anim;

    private void Awake()
    {
        //controller = GetComponent<CharacterController>();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Speed = 6.0f;
        anim = frog.GetComponent<Animator>();
        skinnedMeshRenderer = frogsBody.GetComponent<SkinnedMeshRenderer>();
        //StartCoroutine(FrogOneCoroutine());
    }
    
    /*IEnumerator FrogOneCoroutine()
    {
        //Idle();
        //yield return new WaitForSeconds(2);
        Crawl();
        /*Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);*/

        /*Vector3 forward;
        float curSpeed= speed * Input.GetAxis("Horizontal");
        forward = transform.TransformDirection(Vector3.forward);
        _characterController.SimpleMove(forward * curSpeed); 

        yield return new WaitForSeconds(5);

    }*/
    
    public void Idle()
    {
        RootMotion();
        anim.SetTrigger("Idle");
    }

    public void Jump()
    {
        RootMotion();
        anim.SetTrigger("Jump");
    }

    public void Crawl()
    {
        RootMotion();
        anim.SetTrigger("Crawl");
        m_Rigidbody.velocity = transform.forward * m_Speed;

    }

    public void Tongue()
    {
        RootMotion();
        anim.SetTrigger("Tongue");
    }

    public void Swim()
    {
        RootMotion();
        anim.SetTrigger("Swim");
    }

    
    public void TurnLeft()
    {
        anim.applyRootMotion = true;
        anim.SetTrigger("TurnLeft");
    }

    public void TurnRight()
    {
        anim.applyRootMotion = true;
        anim.SetTrigger("TurnRight");
    }


    void RootMotion()
    {
        if (anim.applyRootMotion)
        {
            anim.applyRootMotion = false;
        }
    }

    

}