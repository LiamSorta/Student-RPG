using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
    //Jamie Cox
    public static float energy = 100;
    public static int money = 100;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (energy <= 0)
        {
            energy = 0;
            Faints();
        }

        energy -= (Time.deltaTime / 5);
        if (energy > 100)
        {
            energy = 100;
        }
       
		if (Pmovement.interact == true) {

						Application.LoadLevel ("Quiz");

				}
	}


    void Faints()
    {

      


    }

    void OnGUI()
    {

        GUI.Box(new Rect(5, 0, 100, 50), "Energy: " + energy, GUIStyle.none);
    }

}
