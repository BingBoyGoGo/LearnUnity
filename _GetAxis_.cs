using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GetAxis_ : MonoBehaviour {

    float axisX;
    float axisY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        axisX = Input.GetAxis("Horizontal");
        axisY = Input.GetAxis("Vertical");

        this.transform.position = new Vector3(axisX, axisY, 0);
	}
}
