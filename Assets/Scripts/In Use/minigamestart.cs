using UnityEngine;
using System.Collections;

public class minigamestart : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor
    
    public static bool playMiniGame = true;
    public static bool inCGame = false;
	// Use this for initialization
	void Start () {
	
	}

    void Update()
    {
        GameObject Cminigame = GameObject.Find("minigameStart");
        //If the minigame has been played this code is executed to prevent the player from playing it
        if (playMiniGame == false)
        {
            Physics2D.IgnoreCollision(Cminigame.collider2D, collider2D);
        }
        Debug.Log("Play Minigame: " + playMiniGame);

        
    }
    //If the minigame hasn't been played this code executes to tke the player to the minigame
	void OnCollisionEnter2D (Collision2D other) {
        if (other.transform.tag == "Cminigamestart")
        {
            Application.LoadLevel("charity_minigame");
        }
	
	}
}
