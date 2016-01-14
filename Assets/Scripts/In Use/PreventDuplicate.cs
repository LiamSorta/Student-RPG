using UnityEngine;
using System.Collections;

public class PreventDuplicate : MonoBehaviour {
    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    //Prevents duplicates of any object this is attached to
    public void Awake()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
            Destroy(gameObject);   
    }
}
