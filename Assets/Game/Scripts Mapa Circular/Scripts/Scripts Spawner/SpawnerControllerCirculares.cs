using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControllerCirculares : MonoBehaviour
{
    public GameObject Player;
    public GameObject spawner;
    public int cambiador;
    public bool spawnSemiC = false;
    public bool spawnL = false;
    public bool spawnWierd = false;
    public bool spawnHelix = false;
    public bool spawnCircle = false;
    public bool spawnRound = false;
    public bool spawnCircleMove = false;
    public bool terminarContador = false;
    public float contador = 2.3f;
    public int cambSpawn = 1;
    public float contadorDificulty = 2.3f;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (terminarContador == false)
        {
            Contador();
            Spawn();
        }
        CambiadorDeSwitch();
    }
    void Spawn()
    {
        if (spawnSemiC && Player.GetComponent<Player>().PlayerDead == false)
        {
            switch (cambiador)
            {
                case 1: spawner.GetComponent<spawner>().spawn = true; cambiador = 0; cambSpawn = 1; break;
            }
        }
        if (spawnL && Player.GetComponent<Player>().PlayerDead == false)
        {
            switch (cambiador)
            {
                case 1: spawner.GetComponent<spawner>().spawn2 = true; cambiador = 0; cambSpawn = 1; break;
            }
        }
        if (spawnCircle && Player.GetComponent<Player>().PlayerDead == false)
        {
            switch (cambiador)
            {
                case 1: spawner.GetComponent<spawner>().spawn3 = true; cambiador = 0; cambSpawn = 1; break;
            }
        }
        if (spawnWierd && Player.GetComponent<Player>().PlayerDead == false)
        {
            switch (cambiador)
            {
                case 1: spawner.GetComponent<spawner>().spawn4 = true; cambiador = 0; cambSpawn = 1; break;
            }
        }
        if (spawnRound && Player.GetComponent<Player>().PlayerDead == false)
        {
            switch (cambiador)
            {
                case 1: spawner.GetComponent<spawner>().spawn6 = true; cambiador = 0; cambSpawn = 1; break;
            }
        }
        if (spawnHelix && Player.GetComponent<Player>().PlayerDead == false)
        {
            switch (cambiador)
            {
                case 1: spawner.GetComponent<spawner>().spawn5 = true; cambiador = 0; cambSpawn = 1; break;
            }
        }
        if (spawnCircleMove && Player.GetComponent<Player>().PlayerDead == false)
        {
            switch (cambiador)
            {
                case 1: spawner.GetComponent<spawner>().spawn7 = true; cambiador = 0; cambSpawn = 1; break;
            }
        }
    }
    void CambiadorDeSwitch()
    {
        if (contador == 0f)
        {
            if(spawnSemiC)
            {
                switch (cambSpawn)
                {
                    case 1: cambiador = 1; contador = contadorDificulty; break;
                }
            }
            if (spawnL)
            {
                switch (cambSpawn)
                {
                    case 1: cambiador = 1; contador = contadorDificulty; break;
                }
            }
            if (spawnRound)
            {
                switch (cambSpawn)
                {
                    case 1: cambiador = 1; contador = contadorDificulty; break;
                }
            }
            if (spawnHelix)
            {
                switch (cambSpawn)
                {
                    case 1: cambiador = 1; contador = contadorDificulty; break;
                }
            }
            if (spawnWierd)
            {
                switch (cambSpawn)
                {
                    case 1: cambiador = 1; contador = contadorDificulty; break;
                }
            }
            if (spawnCircle)
            {
                switch (cambSpawn)
                {
                    case 1: cambiador = 1; contador = contadorDificulty; break;
                }
            }
            if (spawnCircleMove)
            {
                switch (cambSpawn)
                {
                    case 1: cambiador = 1; contador = contadorDificulty; break;
                }
            }
        }
    }
    void Contador()
    {
        contador = contador - 1 * Time.deltaTime;
        if (contador < 0)
        {
            contador = 0;
        }
    }
}