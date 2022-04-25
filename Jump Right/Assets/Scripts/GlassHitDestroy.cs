using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlassHitDestroy : MonoBehaviour
{
    private BoxCollider bc;

    private void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bumped into me !!!");
        if(collision.gameObject.name == "Player")
        {
            bc.isTrigger = true;
            //Destroy(GameObject.Find("Glass"));
            //GetComponent<MeshRenderer>().material.color = Color.red;
        }
        //SceneManager.LoadScene("SampleScene");
        
    }
}
