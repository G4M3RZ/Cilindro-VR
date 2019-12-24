using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDireccionHelix : MonoBehaviour {

public int RandomDirection;
	// Use this for initialization
	void Start ()
    {
        RandomDirection = Random.Range(0, 2);
        ChangeDirection();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void ChangeDirection()
    {
        if(RandomDirection == 1)
        {
            transform.rotation = Quaternion.Euler(0, 180, Random.Range(0, 90));
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 90));
        }
    }
}
