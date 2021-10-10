using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float x;
    float y;
    
    Rigidbody2D controller;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.AddForce(new Vector2(1, 1));
        
    }
}
