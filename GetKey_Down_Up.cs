using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey_Down_Up : MonoBehaviour {

    bool key;
    bool keydown;
    bool keyup;
    float angle;

	// Use this for initialization
	void Start () {
        angle = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        key = Input.GetKey("left");
        keydown = Input.GetKeyDown("left");
        keyup = Input.GetKeyUp("left");
        if (keydown) {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 1);
        }
        if (key) {
            //this.transform.eulerAngles = new Vector3(this.transform.rotation.x,
            //                                        this.transform.rotation.y + 10.0f,
            //                                        //Mathf.MoveTowardsAngle(this.transform.rotation.y,this.transform.rotation.y + 2.0f, Time.deltaTime), 
            //                                        this.transform.rotation.z);
            this.transform.Rotate(Vector3.up, 6.0f);
        }
        if (keyup) {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 1);
        }
	}
}
