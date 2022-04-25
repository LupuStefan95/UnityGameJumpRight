using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassHitChange : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.name == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
