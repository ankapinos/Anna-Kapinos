using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFlightData : MonoBehaviour
{
    public Text textSpeed;
    public Text textHeight;
    public GameObject player;
    public float warningHeight = 580;
    public GameObject warnImage;
    private FlyJoystick flyJoystick;

    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();        
    }

    // Update is called once per frame
    void Update()
    {
        textHeight.text =  "Alt: " + transform.position.y.ToString() + " m";
        textSpeed.text = "Speed: " + (flyJoystick.speed*(-1)).ToString() + " km/h";

        if(transform.position.y>warningHeight){
            warnImage.gameObject.SetActive(false);
        } else{
            warnImage.gameObject.SetActive(true);
        }
          Debug.Log("Speed: " + flyJoystick.speed);

    }
}
