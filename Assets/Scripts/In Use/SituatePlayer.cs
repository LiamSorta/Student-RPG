using UnityEngine;
using System.Collections;

public class SituatePlayer : MonoBehaviour {
    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    public GameObject player;
    public GameObject posLoader;
    Vector3 loadPos;
    
    void Start () {
        loadPos = posLoader.GetComponent<LastPos>()._hallPos;
        player.transform.position = loadPos;
        Debug.Log(loadPos);
	}

}
