using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smooth;

    void Start()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        CameraTakip();
    }

    private void CameraTakip()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, smooth);
    }
}
