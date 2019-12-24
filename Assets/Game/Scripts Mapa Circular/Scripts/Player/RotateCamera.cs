using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {
    //private Vector3 rotation;
    public float currentRotationZ;
    public bool GameInPlay = true;

    public float angularSpeed;

	// Use this for initialization
	void Start ()
    {
        currentRotationZ = 0;
	}
	// Update is called once per frame
	void Update () {
        if (GameInPlay)
        {
            currentRotationZ -= transform.rotation.z * Time.deltaTime * 35;
        }
    }
    public float GetCurrentRotationZ()
    {
        return currentRotationZ;
    }
}
