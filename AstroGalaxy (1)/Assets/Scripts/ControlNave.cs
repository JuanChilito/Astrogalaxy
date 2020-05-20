using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNave : MonoBehaviour
{
    [Header("Disparo")]
    public GameObject disparo;
    public Transform posdisparo;
    public float tiempodisparo;
    private float Ndisparo;
    // Start is called before the first frame update
    void Start()
    {
        tiempodisparo = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-20f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(20f * Time.deltaTime, 0, 0);
        }

        if (Input.GetButton("Fire1")&& Time.time > Ndisparo) 
        {
            Ndisparo = Time.time + tiempodisparo;
            Instantiate(disparo, posdisparo.position, Quaternion.identity);
        }
    }
}
