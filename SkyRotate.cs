using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotate : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
   void Start () {
        // z = 0.5f;  //velocity
     }
     
    void Update () {
         gameObject.transform.Rotate(new Vector3(0,speed, 0)); //applying rotation
     }
}
