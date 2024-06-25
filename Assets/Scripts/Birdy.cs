using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour

{
    public Rigidbody2D myRigidbody;
    public float JumpStrength;

    void Start()
    {
        gameObject.name = "Birdy Hamilton";
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Space) == true)
    {
    myRigidbody.velocity = Vector2.up * JumpStrength;
    }


        
    }
}
