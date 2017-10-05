using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Rotate第一种
        this.transform.Rotate(0, 45f * Time.deltaTime, 0, Space.World);
        //this.transform.Rotate(new Vector3(0, 1, 0), 45f * Time.deltaTime, Space.World);
    }
}
