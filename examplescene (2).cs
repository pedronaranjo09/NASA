using UnityEngine;
using System.Collections;

public class examplescene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        current = (Material)Resources.Load("Skybox2_7/Skybox2_7");
        RenderSettings.skybox = current; 
        GameObject.Find("Main Camera").AddComponent<SmoothMouseLook>();	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0.7f, 0));
 

        if (current == null)
            return;

        current.SetFloat("_Rotation", rotation);
    }

    Material current;

    float rotation;

	void OnGUI() {
		int x = 50;
		int y = 50;
		int dy = 40;
		int cnt = 0;
		int sx = 300;
		int sy = 30;
        for (int i=1;i<=11;i++)


        cnt = 0;
        float ssx = 150;
       

        cnt++;
        rotation = GUI.HorizontalSlider(new Rect(x + ssx, Screen.height - cnt * dy - y, 2 * sx, dy), rotation, 0, 360);

    }
}
