using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVERayo : MonoBehaviour
{
    private Rigidbody rig;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 16f;
        rig = GetComponent<Rigidbody>();
        rig.velocity = transform.forward * velocidad;
    }

}
