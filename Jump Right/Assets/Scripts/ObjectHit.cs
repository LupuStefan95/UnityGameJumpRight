using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bumped into me !!!");
        SceneManager.LoadScene("SampleScene");
        //GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
