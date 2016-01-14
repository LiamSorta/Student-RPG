using UnityEngine;
using System.Collections;

public class SceneItemBools : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    public bool isHeaterOn;
    public bool pizzaEaten;


    void TurnOnHeater() 
    {
        isHeaterOn = true;
    }

    void PizzaEaten()
    {
        pizzaEaten = true;
    }
}
