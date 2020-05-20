using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DestruirporColision : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Limites"))
        {
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
