using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour

{
    public Rigidbody2D myRigidbody;
    public float JumpStrength;
    public LogicManager Logic;
    public bool birdIsAlive = true;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        gameObject.name = "Birdy Hamilton";
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
    {
    myRigidbody.velocity = Vector2.up * JumpStrength;
    }


      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        birdIsAlive = false;
    }
}
    