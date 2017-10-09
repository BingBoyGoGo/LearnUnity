using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Avaribles : MonoBehaviour {

    public Time t;
    bool b;

	// Use this for initialization
	void Start () {
        b = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (b)
            {
                Time.timeScale = 0.2f;
                Time.fixedDeltaTime = 0.004f;
            }
            else {
                Time.timeScale = 1.0f;
                Time.fixedDeltaTime = 0.02f;
            }
            b = !b;
        }

    //void OnGUI() {
    //        GUILayout.TextArea("Now TimeScale: " + Time.timeScale.ToString(), 200);
    //        GUILayout.TextArea("Now fixedTimeStep: " + Time.fixedDeltaTime.ToString(), 200);
    //    }
	}
}
