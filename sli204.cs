using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sli204 : MonoBehaviour {
    public GameObject sphere;

    public void Slider_Changed(float newValue)
    {
        Vector3 pos = sphere.transform.localScale;
        pos.y = newValue;
        pos.x = newValue;
        pos.z = newValue;
        sphere.transform.localScale = pos;
       

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
