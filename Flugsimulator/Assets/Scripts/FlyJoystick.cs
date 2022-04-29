using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed = 100;
    public float speedAmplifier = 100;
    public float rotationSpeed = 50;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputPitch = Input.GetAxis ("Pitch");
        float inputRoll = Input.GetAxis ("Roll");
        float inputYaw = Input.GetAxis ("Yawn");
        float inputThrottle = Input.GetAxis ("Throttle");
        float Pitch = inputPitch*Time.deltaTime*rotationSpeed;
        float Roll = inputRoll*Time.deltaTime*rotationSpeed;
        float Yaw = inputYaw*Time.deltaTime*rotationSpeed;
        Debug.Log("inputPitch: " + inputPitch);

         speed = inputThrottle*speedAmplifier;
         this.transform.Rotate(Pitch,Roll, Yaw);

        this.transform.Translate(Vector3.forward*speed*Time.deltaTime); 

         if (Input.GetAxis ("Throttle")>0){
             this.transform.Translate(Vector3.forward*speed*Time.deltaTime);
         }
            Debug.Log("inputThrottle: " + inputThrottle);

    }
}
