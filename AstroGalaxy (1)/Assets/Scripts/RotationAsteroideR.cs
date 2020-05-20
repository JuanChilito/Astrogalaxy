using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAsteroideR : MonoBehaviour
{
    private Rigidbody rigb;
    public float velocidadrotation;
    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody>();
        velocidadrotation = 3f;
        rigb.angularVelocity = Random.insideUnitSphere * velocidadrotation;
    }
}
