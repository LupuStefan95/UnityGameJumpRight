using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bumped into me !!!");
        if(collision.gameObject.name == "Player")
        {
            Destroy(GameObject.Find("Cube"));
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        //SceneManager.LoadScene("SampleScene");
        
    }
}
