using UnityEngine;
using System.Collections;

public class StartSceneHeater : MonoBehaviour {
    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    void Start()
    {

        if (GameObject.FindGameObjectWithTag("GM").GetComponent<SceneItemBools>().isHeaterOn)
        {
            GameObject.FindGameObjectWithTag("InteractChat").GetComponent<TextWriter>().heaterOn = true;
            GetComponent<Animator>().SetBool("heaterOn", true);
            GetComponent<Animator>().speed = 10f;
        }

        if (GameObject.FindGameObjectWithTag("GM").GetComponent<SceneItemBools>().pizzaEaten)
        {
            GameObject.FindGameObjectWithTag("Flatmate").renderer.enabled = true;
            GameObject.FindGameObjectWithTag("Flatmate").collider2D.enabled = true;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Flatmate").renderer.enabled = false;
            GameObject.FindGameObjectWithTag("Flatmate").collider2D.enabled = false;
        }
    }
	
	
	void Update () {
	
	}
}
