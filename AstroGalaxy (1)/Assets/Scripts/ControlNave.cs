using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNave : MonoBehaviour
{
    [Header("ControlNave")]
    public float velocidadNave = 20;
    Rigidbody rigidNave;
    Vector3 movimiento;


    [Header("Disparo")]
    public GameObject disparo;
    public Transform posdisparo;
    public float tiempodisparo;
    private float Ndisparo;
    // Start is called before the first frame update
    void Start()
    {
        rigidNave = GetComponent<Rigidbody>();
        tiempodisparo = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1")&& Time.time > Ndisparo) 
        {
            Ndisparo = Time.time + tiempodisparo;
            Instantiate(disparo, posdisparo.position, Quaternion.identity);
        }
    }

    void FixedUpdate() 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        MoverNave(h, v);
        LimiteNave();
        RotacionNave();
    }

    void MoverNave(float h, float v)
    {
        movimiento = new Vector3(h, 0.0f, v);
        rigidNave.velocity = movimiento * velocidadNave;
    }

    void LimiteNave()
    {
        rigidNave.position = new Vector3(Mathf.Clamp(rigidNave.position.x,-7.8f,7.8f), 0.0f, Mathf.Clamp(rigidNave.position.z,-3f,14f));
    }
     void RotacionNave()
    {
        rigidNave.rotation = Quaternion.Euler(rigidNave.velocity.z * 1f, 0.0f, rigidNave.velocity.x * -1f);
    }
}
