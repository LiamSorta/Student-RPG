using UnityEngine;
using System.Collections;

public class KillThePizza : MonoBehaviour {
    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    public GameObject Pizza;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("GM").GetComponent<SceneItemBools>().pizzaEaten)
            Pizza.SetActive(false);
        else
            Pizza.SetActive(true);
    }
}
