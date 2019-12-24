using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public bool PlayerDead = false;
    public bool PowerUP = false;
    public GameObject ObstEnd;
    public GameObject DeadParticulas;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerDead)
        {
            ObstEnd.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            ObstEnd.GetComponent<BoxCollider>().enabled = false;
        }
        
        MovimientoNaranja();
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if(PowerUP == false)
            {
                PlayerDead = true;
                GetComponent<MeshRenderer>().enabled = false;
            }
            Instantiate(DeadParticulas, transform.position, transform.rotation);
        }
    }
    void MovimientoNaranja()
    {
        transform.Rotate(700 * Time.deltaTime, 0, 0);
    }
}
