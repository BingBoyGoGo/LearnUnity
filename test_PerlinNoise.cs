using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_PerlinNoise : MonoBehaviour {

    Renderer rend;
    Vector3 ColorSpace;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        ColorSpace = new Vector3(
                        Random.Range(0, 10),
                        Random.Range(0, 10),
                        Random.Range(0, 10));
	}
	
	// Update is called once per frame
	void Update () {
        //this.rend.material.color = new Color(Mathf.PerlinNoise(Time.time, ColorSpace.x),
        //                                     Mathf.PerlinNoise(Time.time, ColorSpace.y),
        //                                     Mathf.PerlinNoise(Time.time, ColorSpace.z));

        // 不使用PerlinNoise()的对比
        this.rend.material.color = new Color(Random.value, Random.value, Random.value);
	}
}
