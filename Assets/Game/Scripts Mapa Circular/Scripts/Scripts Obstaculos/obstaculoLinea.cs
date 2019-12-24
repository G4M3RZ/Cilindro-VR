using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculoLinea : MonoBehaviour {
    public bool RotZ = false;
    public float contadorL = 0f;
    public float num = 0.5f;
	// Use this for initialization
	void Start ()
    {
        RotZ = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Rotacion();
        LimitRotation();
	}
    void Rotacion()
    {
        if (RotZ)
        {
            transform.Rotate(0, 0, 20*Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, -20*Time.deltaTime);
        }
    }
    void LimitRotation()
    {
        contadorL += Time.deltaTime;
        if (contadorL >= num && RotZ)
        {
            RotZ = false;
            contadorL = 0;
            num = 1f;
        }
        if (contadorL >= num && RotZ == false)
        {
            RotZ = true;
            contadorL = 0;
            num = 1f;
        }
    }
}
