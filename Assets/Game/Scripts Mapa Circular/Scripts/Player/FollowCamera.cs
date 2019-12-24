using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public RotateCamera compRotateCamera;
    public GameObject obsController;
    private float movementFactor = 1.5f;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () {
        float rotY = compRotateCamera.GetCurrentRotationZ();
        float offset = rotY * movementFactor * 1.5f;
        obsController.GetComponent<obsController>().rotacion = offset;
    }
}
