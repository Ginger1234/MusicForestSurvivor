using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chomper2 : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
     void Update()
    {
        transform.LookAt(target);
    }
}
