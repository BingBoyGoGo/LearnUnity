using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternion : MonoBehaviour {

    public Quaternion quat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.rotation = quat;
	}
}
