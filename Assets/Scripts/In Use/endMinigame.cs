using UnityEngine;
using System.Collections;

public class endMinigame : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    bool minigameEnd = false;

    void OnAwake()
    {
    }
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D other) {
        if (other.transform.tag == "charityWorker")
        {
            Achievements.failCharityGame = true;
            Buggie_UI.money -= Buggie_UI.money;
            minigameEnd = true;

        }
        if (other.transform.tag == "endObject")
        {
            Achievements.winCharityGame = true;
            minigameEnd = true;
            
        }
        if (other.transform.tag == "achievement")
        {
            Achievements.fastCharity = true;
        }
	}
    void Update()
    {
        if (minigameEnd == true)
        {
            Application.LoadLevel("Street");
            minigamestart.playMiniGame = false;
        }
    }
}
