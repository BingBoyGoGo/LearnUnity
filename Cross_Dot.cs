using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross_Dot : MonoBehaviour {

    Vector3 a;
    Vector3 b;
    Transform t;
    Vector3 cross;
    Vector3 vdot;
    float dot;

	// Use this for initialization
	void Start () {
        // 静态变量
        a = Vector3.right;
        b = Vector3.up;
    }
	
	// Update is called once per frame
	void Update () {
        t = this.transform;
        a = new Vector3(t.position.x, t.position.y + 10, t.position.z);
        b = new Vector3(t.position.x, t.position.y, t.position.z + 10);

        // 点乘，返回float
        dot = Vector3.Dot(a, b);
        // 转换成点
        vdot = new Vector3(t.position.x + dot, t.position.y + dot, t.position.z + dot);

        // 叉乘
        cross = Vector3.Cross(a, b);

        // 画线显示结果
        Debug.DrawLine(t.position, 10f * a + t.position, Color.green);
        Debug.DrawLine(t.position, 10f * b + t.position, Color.green);
        Debug.DrawLine(t.position, 10f * cross + t.position, Color.red);
        Debug.DrawLine(t.position, 10f * vdot, Color.blue);
    }
}
