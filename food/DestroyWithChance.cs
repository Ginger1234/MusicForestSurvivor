using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithChance : MonoBehaviour
{
    [Range(0,1)]
    public float ChanceOfStaying = 0.5f;
    private void Start()
    {
        if (Random.value > ChanceOfStaying)
            Destroy (gameObject);
    }
}
