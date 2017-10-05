using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 请求Rigidbody,显示Rigidbody面板,确保GetComponent<>()可用
[RequireComponent(typeof(Rigidbody))]

public class MyRequireComponent : MonoBehaviour {

    // 声明一个Rigidbody对象
    public Rigidbody rb;
    // 声明一个EnableAndDisable对象(脚本)
    public EnableAndDisable ead;

    private void Awake()
    {
        // 获取面板中的脚本，放在Awake()中，先于Start加载避免脚本出现没有参考的错误
        ead = gameObject.GetComponent<EnableAndDisable>();
    }

    // Use this for initialization
    void Start () {
        // 获取组件
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(0, 1.0f, 0, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
