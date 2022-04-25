using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassHitChange : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bumped into me !!!");
        if (collision.gameObject.name == "Player")
        {
           // Destroy(GameObject.Find("Glass2"));
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        //SceneManager.LoadScene("SampleScene");

    }
}
