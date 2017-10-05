using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

    GameObject traget;
    Vector3 top;
    Vector3 button;

	// Use this for initialization
	void Start () {
        traget = GameObject.Find("Rotate1");
	}
	
	// Update is called once per frame
	void Update () {
        top = new Vector3(traget.transform.position.x + 5f,
                          traget.transform.position.y,
                          traget.transform.position.z);
        button = new Vector3(traget.transform.position.x - 5f,
                          traget.transform.position.y,
                          traget.transform.position.z);
        Debug.DrawLine(top, button, Color.red);

        this.transform.RotateAround(traget.transform.position, Vector3.right, 45f * Time.deltaTime);
	}
}
