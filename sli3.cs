using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class sli3 : MonoBehaviour {
    public MeshRenderer sphere;
    public Slider red;

    public void OnEdit()
    {
        Color color = sphere.material.color;
        color.r = red.value;
        sphere.material.color = color;
        sphere.material.SetColor("_EmissionColor", color);
       

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
