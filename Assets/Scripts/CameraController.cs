using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
        //target = PlayerController.instance.transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        //transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}