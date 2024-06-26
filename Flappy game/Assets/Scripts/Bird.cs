using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public  Rigidbody2D myRigidbody;    
    public LogicManager Logic;
    public float jumpStrength;

    public bool birdisAlive;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        birdisAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdisAlive == true)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        birdisAlive = false;
    }
}
