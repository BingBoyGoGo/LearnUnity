using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ooo : MonoBehaviour {

    public Vector3 pos;
    public Vector3 pos2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(pos.ToString() + " " + pos2.ToString() + "  Distance: " + Vector3.Distance(pos, pos2).ToString());
        Debug.Log(pos.ToString() + " " + pos2.ToString() + "  Angle: " + Vector3.Angle(pos, pos2).ToString());
        Debug.Log(pos.ToString() + " " + pos2.ToString() + "  Magnitude: " + Vector3.Magnitude(pos).ToString() + " " + Vector3.Magnitude(pos2).ToString() );
        Debug.Log(pos.ToString() + " " + pos2.ToString() + "  normalize: " + Vector3.Normalize(pos).ToString() + " " + Vector3.Normalize(pos2).ToString() );
    }
}
