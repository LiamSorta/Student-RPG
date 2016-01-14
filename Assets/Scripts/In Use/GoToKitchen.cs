using UnityEngine;
using System.Collections;

public class GoToKitchen : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
            Application.LoadLevel("Kitchen");
    }

}
