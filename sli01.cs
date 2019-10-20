using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sli01 : MonoBehaviour {

    public float x;
    public float y;
    public float z;
    public float v;



    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	public void Update () {
        //x = y = z;
        x += v;
        y += v;
        z += v;
        transform.localScale= new Vector3(x,y,z);
	}
}
