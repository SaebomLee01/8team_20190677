using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3 camOffset = new Vector3(0.0f, 0.0f, -5.0f);
    private Transform target;

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.TransformPoint(camOffset);
        transform.LookAt(target);
    }
}
