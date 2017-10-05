using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 六种碰撞
// 呼出面板
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class Rigidbody_Collider_Trigger : MonoBehaviour {

    public Rigidbody rb;
    public Collider cld;
    public GameObject obj1;
    public GameObject obj2;
    public Rigidbody rgb; // 施加力
    public Collider col; // Debug.Log()

    // 注意在Inspector中修改碰撞物体的static属性
	// Use this for initialization
	void Start () {
        obj1 = GameObject.Find("CRTCube_1");
        obj2 = GameObject.Find("CRTCube_2");
        rgb.GetComponent<Rigidbody>();
        col.GetComponent<Collider>();

        // 1 static collider
        //cld = gameObject.GetComponent<Collider>();
        //cld.isTrigger = false;

        //// 2 rigidbody collider
        //cld = gameObject.GetComponent<Collider>();
        //rb = gameObject.GetComponent<Rigidbody>();
        //cld.isTrigger = false;
        //rb.isKinematic = false;

        //// 3 Kinematic Rigidbody Collider
        //cld = gameObject.GetComponent<Collider>();
        //rb = gameObject.GetComponent<Rigidbody>();
        //rb.isKinematic = true;
        //cld.isTrigger = false;

        //// 4 Static Trigger Collider
        cld = gameObject.GetComponent<Collider>();
        cld.isTrigger = true;

        //// 5 Rigidbody Trigger Collider
        //cld = gameObject.GetComponent<Collider>();
        //rb = gameObject.GetComponent<Rigidbody>();
        //cld.isTrigger = true;
        //rb.isKinematic = false;

        //// 6 Kinematic Rigidbody Trigger Collider
        //cld = gameObject.GetComponent<Collider>();
        //rb = gameObject.GetComponent<Rigidbody>();
        //cld.isTrigger = true;
        //rb.isKinematic = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }

    // Update is called once per frame
    void Update () {
        rgb.AddForce(0, 0, 0.1f, ForceMode.Impulse);
        
    }

    void FixedUpdate(){
        
    }
}
