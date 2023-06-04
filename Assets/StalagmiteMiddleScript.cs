using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalagmiteMiddleScript : MonoBehaviour
{
    public LogicScipt logic;
    public Bat_Script batscript;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScipt>();
        batscript = GameObject.FindGameObjectWithTag("Bat").GetComponent<Bat_Script>();
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        
        
        if(collision.gameObject.layer == 3){
           if(batscript.batIsAlive){
            logic.addScore(1);
           }
            
           
           
           
        }
        


        
    }
}
