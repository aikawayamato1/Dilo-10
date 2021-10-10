using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float x;
    float y;
    Vector3 MousePos;
    Vector3 dir;

    public Rigidbody2D controller;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dir = (MousePos - transform.position).normalized;
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        
    }
    private void FixedUpdate()
    {
        controller.AddForce(new Vector2(dir.x*Speed, dir.y*Speed));
    }
}
