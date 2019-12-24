using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje : MonoBehaviour {
    public GameObject Player;
    public GameObject MenuInteractivoInGame;
    public GameObject SpawnerController;
    public float Contador = 0f;
    float ContadorCmabioObs = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ContadorInGame();
        CambiadorDeObstaculo();
	}
    void ContadorInGame()
    {
        if (Player.GetComponent<Player>().PlayerDead == false && MenuInteractivoInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            Contador += 1 * Time.deltaTime * 5;
        }
        if (Player.GetComponent<Player>().PlayerDead == false && MenuInteractivoInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            ContadorCmabioObs += 1 * Time.deltaTime * 5;
        }

    }
    void CambiadorDeObstaculo()
    {
        if (ContadorCmabioObs < 200)
        {
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnSemiC = true;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnL = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircle = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnHelix = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnWierd = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircleMove = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnRound = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().contadorDificulty = 2.3f;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().terminarContador = false;
        }
        if(ContadorCmabioObs >= 200 && ContadorCmabioObs < 215)
        {
            NullObst();
        }
        if (ContadorCmabioObs >= 215 && ContadorCmabioObs < 255)
        {
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnSemiC = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnL = true;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircle = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnHelix = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnWierd = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircleMove = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnRound = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().contadorDificulty = 0.1f;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().terminarContador = false;
        }
        if (ContadorCmabioObs >= 255 && ContadorCmabioObs < 270)
        {
            NullObst();
        }
        if (ContadorCmabioObs >= 270 && ContadorCmabioObs < 470)
        {
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnSemiC = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnL = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircle = true;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnHelix = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnWierd = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircleMove = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnRound = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().contadorDificulty = 2.3f;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().terminarContador = false;
        }
        if (ContadorCmabioObs >= 470 && ContadorCmabioObs < 485)
        {
            NullObst();
        }
        if (ContadorCmabioObs >= 485 && ContadorCmabioObs < 685)
        {
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnSemiC = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnL = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircle = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnHelix = true;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnWierd = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircleMove = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnRound = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().contadorDificulty = 2.3f;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().terminarContador = false;
        }
        if (ContadorCmabioObs >= 685 && ContadorCmabioObs < 700)
        {
            NullObst();
        }
        if (ContadorCmabioObs >= 700 && ContadorCmabioObs < 900)
        {
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnSemiC = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnL = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircle = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnHelix = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnRound = true;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnWierd = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircleMove = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().contadorDificulty = 2.3f;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().terminarContador = false;
        }
        if (ContadorCmabioObs >= 900 && ContadorCmabioObs < 915)
        {
            NullObst();
        }
        if (ContadorCmabioObs >= 915 && ContadorCmabioObs < 1115)
        {
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnSemiC = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnL = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircle = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnHelix = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnRound = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnWierd = true;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircleMove = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().contadorDificulty = 2.3f;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().terminarContador = false;
        }
        if (ContadorCmabioObs >= 1115 && ContadorCmabioObs < 1130)
        {
            NullObst();
        }
        if(ContadorCmabioObs >= 1130 && ContadorCmabioObs < 1330)
        {
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnSemiC = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnL = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircle = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnHelix = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnRound = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnWierd = false;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircleMove = true;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().contadorDificulty = 2.3f;
            SpawnerController.GetComponent<SpawnerControllerCirculares>().terminarContador = false;
        }
        if (ContadorCmabioObs >=1330 && ContadorCmabioObs < 1345)
        {
            NullObst();
        }
        if (ContadorCmabioObs >= 1345)
        {
            ContadorCmabioObs = 0f;
        }
    }
    void NullObst()
    {
        /*SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnSemiC = false;
        SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnL = false;
        SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnCircle = false;
        SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnHelix = false;
        SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnWierd = false;
        SpawnerController.GetComponent<SpawnerControllerCirculares>().spawnRound = false;*/
        SpawnerController.GetComponent<SpawnerControllerCirculares>().contadorDificulty = 2.3f;
        SpawnerController.GetComponent<SpawnerControllerCirculares>().terminarContador = true;
    }
}
