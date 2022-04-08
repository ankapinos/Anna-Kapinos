using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class SwitchScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.rotation.z);
        if (this.transform.rotation.z>=0.6){
                 SceneManager.LoadScene(sceneName:"Cockpit");

        }
    }
}
