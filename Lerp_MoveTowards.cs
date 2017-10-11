using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp_MoveTowards : MonoBehaviour {

    public Vector3 pos;
    private float t;
    public float maxDistanceDelta; // MoveTowards()中deltaTime时间里最大距离

    // Use this for initialization
    void Start () {
        t = Time.time;
	}

    void FixedUpdate(){
        
    }

    // Update is called once per frame
    void Update () {
        // Vector3.Lerp() 移动到pos
        //this.transform.position = Vector3.Lerp(this.transform.position, pos, (Time.time - t)/30f);

        // Vector3.MoveTowards() 移动到pos 
        this.transform.position = Vector3.MoveTowards(this.transform.position, pos, maxDistanceDelta * Time.deltaTime);
    }
}
