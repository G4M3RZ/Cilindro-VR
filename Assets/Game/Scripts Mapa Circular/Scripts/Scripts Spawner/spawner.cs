using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject semiCirculo;
    public GameObject linea;
    public GameObject wierd;
    public GameObject helix;
    public GameObject circle;
    public GameObject round;
    public GameObject circleMove;
    public GameObject objetoPadre;
    public GameObject ControllerMenuInGame;

    public bool Cambio = false;

    public bool spawn  = false;
    public bool spawn2 = false;
    public bool spawn3 = false;
    public bool spawn4 = false;
    public bool spawn5 = false;
    public bool spawn6 = false;
    public bool spawn7 = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn && ControllerMenuInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            Spawn();
            spawn = false;
        }
        if (spawn2 && ControllerMenuInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            Spawn2();
            spawn2 = false;
        }
        if (spawn3 && ControllerMenuInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            Spawn3();
            spawn3 = false;
        }
        if (spawn4 && ControllerMenuInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            Spawn4();
            spawn4 = false;
        }
        if (spawn5 && ControllerMenuInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            Spawn5();
            spawn5 = false;
        }
        if (spawn6 && ControllerMenuInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            Spawn6();
            spawn6 = false;
        }
        if (spawn7 && ControllerMenuInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            Spawn7();
            spawn7 = false;
        }

    }
    void Spawn()
    {
        Vector3 rotacion = Vector3.forward * Random.Range(0, 365);
        GameObject objetoHijo = Instantiate(semiCirculo,transform.position, Quaternion.Euler(rotacion)) as GameObject;
        objetoHijo.transform.parent = objetoPadre.transform;
        objetoHijo.transform.position = objetoPadre.transform.position;
    }
    void Spawn2()
    {
        GameObject objetoHijo = Instantiate(linea, transform.position, Quaternion.Euler(0, 0, 90)) as GameObject;
        objetoHijo.transform.parent = objetoPadre.transform;
        objetoHijo.transform.position = objetoPadre.transform.position;
    }
    void Spawn3()
    {
        Vector3 rotacion = Vector3.forward * Random.Range(0, 365);
        GameObject objetoHijo = Instantiate(circle, transform.position, Quaternion.Euler(rotacion)) as GameObject;
        objetoHijo.transform.parent = objetoPadre.transform;
        objetoHijo.transform.position = objetoPadre.transform.position;
    }
    void Spawn4()
    {
        Vector3 rotacion = Vector3.forward * Random.Range(0, 365);
        GameObject objetoHijo = Instantiate(wierd, transform.position, Quaternion.Euler(rotacion)) as GameObject;
        objetoHijo.transform.parent = objetoPadre.transform;
        objetoHijo.transform.position = objetoPadre.transform.position;
    }
    void Spawn5()
    {
        Vector3 rotacion = Vector3.forward * Random.Range(0, 90);
        GameObject objetoHijo = Instantiate(helix, transform.position, Quaternion.Euler(rotacion)) as GameObject;
        objetoHijo.transform.parent = objetoPadre.transform;
        objetoHijo.transform.position = objetoPadre.transform.position;
    }
    void Spawn6()
    {
        Vector3 rotacion = Vector3.forward * Random.Range(0, 365);
        GameObject objetoHijo = Instantiate(round, transform.position, Quaternion.Euler(rotacion)) as GameObject;
        objetoHijo.transform.parent = objetoPadre.transform;
        objetoHijo.transform.position = objetoPadre.transform.position;
    }
    void Spawn7()
    {
        Vector3 rotacion = Vector3.forward * Random.Range(0, 365);
        GameObject objetoHijo = Instantiate(circleMove, transform.position, Quaternion.Euler(rotacion)) as GameObject;
        objetoHijo.transform.parent = objetoPadre.transform;
        objetoHijo.transform.position = objetoPadre.transform.position;
    }
}
