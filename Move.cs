using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float startValue;
    public float endValue;
    public float t;
    float movedir;
    float currentX;
    public float MoveTowardsMaxPos;
    public float target;
    public float speed;

	// Use this for initialization
	void Start () {
        t = 0.5f;
    }

    void FixedUpdate(){
        // Mathf.Clamp() 限制输入的范围
        t = Mathf.Clamp(t, 0, 4);
        startValue = Mathf.Clamp(startValue, 0, 10);
        endValue = Mathf.Clamp(endValue, startValue, 20);
        currentX = this.transform.position.x;

        // lerp() 设置T 
        //movedir = Mathf.Lerp(startValue, endValue, Time.time - t);
        //this.transform.position = new Vector3(movedir, this.transform.position.y, this.transform.position.z);

        // SmoothStep() 设置T, endValue
        this.transform.position = new Vector3(Mathf.SmoothStep(this.transform.position.x, endValue, Time.time - t),
                                                this.transform.position.y,
                                                this.transform.position.z);

        // SmoothDamp()  设置T,speed,target
        //this.transform.position = new Vector3(Mathf.SmoothDamp(this.transform.position.x, target,ref speed, t, 10.0f, Time.deltaTime),
        //                                        this.transform.position.y,
        //                                        this.transform.position.z);

        // MoveToward()
        //// 以下会持续运动
        //target = new Vector3(this.transform.position.x + 0.1f, this.transform.position.y, this.transform.position.z);
        //currentX = Mathf.MoveTowards(currentX, this.transform.position.x + 0.1f, 1.0f * Time.deltaTime);
        //this.transform.position = new Vector3(currentX,this.transform.position.y, this.transform.position.z);
        // 以下会移动到某个地点
        //this.transform.position = new Vector3(Mathf.MoveTowards(this.transform.position.x, target, speed * Time.deltaTime), 
        //                                        this.transform.position.y,
        //                                        this.transform.position.z);

    }

    // Update is called once per frame
    void Update () {
		
	}

}
