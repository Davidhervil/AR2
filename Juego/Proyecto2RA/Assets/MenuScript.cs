using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public Color OnMouseOverColor = Color.yellow;
    public Color OnMouseClickColor = Color.red;
    public Color OnMouseExitColor = Color.cyan;

    void Start()
    {

    }

    void OnMouseOver()
    {
        GetComponent<TextMesh>().color = OnMouseOverColor;
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<TextMesh>().color = OnMouseClickColor;
            if (transform.tag == "BackToMenu")
                SceneManager.LoadScene("Menu");
            else if (transform.tag == "ExitText")
                Application.Quit();
            else if (transform.tag == "Play1")
                SceneManager.LoadScene("Level1");
            else if (transform.tag == "Play2")
                SceneManager.LoadScene("Level2");
        }
    }
    void OnMouseExit()
    {
        GetComponent<TextMesh>().color = Color.cyan;
    }


}
