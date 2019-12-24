using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInteractivoPlay : MonoBehaviour {
    public GameObject PlayButon;
    public GameObject OptionsButton;

    public GameObject FadeInicial;
    public GameObject FadeFinal;

    private float contadorCmabioSenas = 1.5f;
    private bool CambioScena = true;
    // Use this for initialization
    void Start ()
    {
        Vector3 posFade = new Vector3(0, 0, 0);
        Instantiate(FadeInicial, posFade, transform.rotation);
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayGame();
        Options();
    }
    public void PlayGame()
    {
        if (PlayButon.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            if (CambioScena)
            {
                Instantiate(FadeFinal, new Vector3(0, 0, 0), transform.rotation);
                CambioScena = false;
            }
            contadorCmabioSenas -= Time.deltaTime;
            if (contadorCmabioSenas <= 0)
            {
                SceneManager.LoadScene(1);
                PlayButon.GetComponent<BotonInteractivo>().ActivarBoton = false;
            }
        }
    }
    public void Options()
    {
        if (OptionsButton.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            if (CambioScena)
            {
                Instantiate(FadeFinal, new Vector3(0, 0, 0), transform.rotation);
                CambioScena = false;
            }
            contadorCmabioSenas -= Time.deltaTime;
            if (contadorCmabioSenas <= 0)
            {
                SceneManager.LoadScene(2);
                OptionsButton.GetComponent<BotonInteractivo>().ActivarBoton = false;
            }
        }
    }
}
