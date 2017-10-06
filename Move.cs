using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float startValue;
    public float endValue;
    public float t;
    float movedir;

	// Use this for initialization
	void Start () {
        // Mathf.Clamp() 限制输入的范围
        t = Mathf.Clamp(t, 0, 4);
        startValue = Mathf.Clamp(startValue, 0, 10);
        endValue = Mathf.Clamp(endValue, 0, 20);
    }

    void FixedUpdate(){
        // lerp()
        movedir = Mathf.Lerp(startValue, endValue, Time.time - t);
        this.transform.position = new Vector3(movedir, this.transform.position.y, this.transform.position.z);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
