using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float sliptStrength;
    public LogicScipt logic;
    public bool batIsAlive = true;

    void Start()
    {
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScipt>();
       batIsAlive = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && batIsAlive)
        {
            myRigidbody.velocity = Vector2.up*sliptStrength;
        }
        if(transform.position.y > 15 || transform.position.y < -15){
            logic.gameOver();
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
       batIsAlive = false;
        if(!batIsAlive){
            logic.gameOver();
        }
        
        
    }
}
