using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatt : MonoBehaviour {

    GameObject target;

	// Use this for initialization
	void Start () {
        target = GameObject.Find("lookatCube");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(target.transform.position);
	}
}
