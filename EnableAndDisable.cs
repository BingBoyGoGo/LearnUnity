using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAndDisable : MonoBehaviour {
    GameObject obj;

	// Use this for initialization
	void Start () {
        Debug.Log(typeof(MeshRenderer));
        obj = GameObject.Find("Cube");
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab))
        {
            obj.GetComponent<MeshRenderer>().enabled = !obj.GetComponent<MeshRenderer>().enabled;
        }
	}
}
