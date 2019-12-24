using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsController : MonoBehaviour {
    public float rotacion;
    public float initialRotZ;
    // Use this for initialization
    void Start ()
    {
        
    }
	// Update is called once per frame
	void Update ()
    {
        initialRotZ = transform.rotation.z;
        Rotacion();
    }
    void Rotacion()
    {
        transform.eulerAngles = new Vector3(0, 0, initialRotZ + rotacion * -16f);
    }
}
