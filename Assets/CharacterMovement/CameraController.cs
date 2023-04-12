using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // the object to follow
    public float zoomSpeed = 10f; // camera zoom speed
    public float minZoom = 2f; // minimum zoom distance
    public float maxZoom = 10f; // maximum zoom distance

    private Camera cam; // camera component

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // check for zoom input
        float zoomDelta = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize - zoomDelta, minZoom, maxZoom);

        // follow target object
        if (target != null)
        {
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
    }
}