using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalagmiteSpawnScript : MonoBehaviour
{
    
    public GameObject stalagmite;
    public float spawnRate = 5;
    private float timer = 0;
    public float heightOffset = 8;
    void Start()
    {
        spawnStalagmite();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
        }else{
            spawnStalagmite();
            timer=0;
        }
        
    }
    void spawnStalagmite(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;


       Instantiate(stalagmite, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
