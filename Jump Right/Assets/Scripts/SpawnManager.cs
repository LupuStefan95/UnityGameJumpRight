using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    StageSpawner stageSpawner;

    // Start is called before the first frame update
    void Start()
    {
        stageSpawner = GetComponent<StageSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        stageSpawner.MoveStage();
    }
}
