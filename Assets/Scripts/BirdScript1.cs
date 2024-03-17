using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool isAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
            myRigidBody.velocity = Vector2.up * flapStrength;
        
        if (gameObject.transform.position.y > 9 || gameObject.transform.position.y < -9)
            endGame();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        endGame();
    }

    private void endGame()
    {
        logic.gameOver();
        isAlive = false;
    }
}