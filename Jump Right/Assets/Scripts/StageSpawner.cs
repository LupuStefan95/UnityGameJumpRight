using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSpawner : MonoBehaviour
{

    public List<GameObject> stages;
    private float offset = 36.98f;
    
    // Start is called before the first frame update
    void Start()
    {
             
    }
    
    public void MoveStage()
    {
        int randomNumber = Random.Range(0, 3);
        GameObject movedStage = stages[0];
        stages.Remove(movedStage);
        //float newZ = stages[stages.Count - 1].transform.position.z + offset;
        float newZ = stages[stages.Count - 1].transform.position.z + offset;
       GameObject nextStage = Instantiate(stages[randomNumber], new Vector3(0, 1, newZ), Quaternion.identity);
       // movedStage.transform.position = new Vector3(0, 0, newZ);
        stages.Add(nextStage);
    }
}
