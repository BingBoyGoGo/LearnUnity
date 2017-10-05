using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SetActive 设置模型可用与不可用

public class SetActive : MonoBehaviour {

    public GameObject obj;
    public bool ac;

	// Use this for initialization
	void Start () {
        ac = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.T))
        {
            obj.SetActive(ac);
            ac = !ac;
        }
	}
}
