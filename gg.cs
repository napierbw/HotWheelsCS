// @author: Benjamin Napier
// This file is used to control the 360 camera view with mouse controls

using System;
using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public GameObject ARCamera;
    public GameObject Camera1;
    public void Start()
    {
        ARCamera.SetActive(false);
        Camera1.SetActive(true);
    }
    public float sensitivity = 10f;
    public void Update()
    {
        var c = Camera.main.transform;
        c.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
        c.Rotate(-Input.GetAxis("Mouse Y") * sensitivity, 0, 0);
        c.Rotate(0, 0, -Input.GetAxis("QandE") * 90 * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;
    }
}