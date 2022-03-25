using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Vector3 movement;
    Rigidbody  rb;
    float speed = 2;
    public bool keyboard;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (keyboard = true)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertikal = Input.GetAxis ("Vertical");
            movement = new Vector3(moveHorizontal, 0f, moveVertikal);
            rb.AddForce (movement*speed);
        }
        

    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
