using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class VirtualButTest : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject Cubo;
	// Use this for initialization
	void Start () {
        Cubo = GameObject.FindWithTag("Player");
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int  i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        switch(vb.VirtualButtonName)
        {
            case "StartButton":
                SceneManager.LoadScene("Level1");
                break;
            default:
                throw new UnityException("Error en el boton");
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "StartButton":
                SceneManager.LoadScene("Level1");
                break;
            case "ExitButton":
                Application.Quit();
                break;
            default:
                throw new UnityException("Error en el boton");
                break;
        }
    }
}
