using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustRotate : MonoBehaviour
{
    public float speed =30;
    void update()
    {
        transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.up);
    }
}