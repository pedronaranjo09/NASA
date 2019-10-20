using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSe4 : MonoBehaviour {

    public Transform alvo;
    public Vector3 eixo;

    public float velocidade;
    public float diametro;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(alvo.position, eixo, velocidade*Time.deltaTime);
	}
}
