using UnityEngine;
using System.Collections;

public class LastPos : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////


    //Used by the GM to hold the last position of the player when exiting a room, usful for rooms that have multiple entrances.

    public Vector3 _hallPos;

    string currentLevel;
    GameObject currentPosObj;
    Transform currentPos;

    void Start()
    {
        currentPosObj = GameObject.FindGameObjectWithTag("Player");
        currentPos = currentPosObj.transform;
        currentLevel = Application.loadedLevelName;
    }
	void Update () {

        //Situates the player when on the level is loaded
        if (currentLevel != Application.loadedLevelName)
            SituatePlayer(Application.loadedLevelName);

        //All levels with multiple entrances/exits to be listed here
        if (currentLevel == "Hall")
            _hallPos = currentPos.position;

	}

    //Sets the transform depending on level name
    void SituatePlayer(string levelName){
        currentLevel = Application.loadedLevelName; //Sets current level to the loaded name to prevent freezing of character
        currentPosObj = GameObject.FindGameObjectWithTag("Player");
        currentPos = currentPosObj.transform;

        if (levelName == "Hall")
            currentPosObj.transform.position = _hallPos - new Vector3(-3, -2, 0) ; //Setting the position when loading into this level with an offset to prevent re-entry


     
    }

}
