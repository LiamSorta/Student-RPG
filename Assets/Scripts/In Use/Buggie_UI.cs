using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Buggie_UI : MonoBehaviour {


    //
    // Script by
    // Josh Bannister
    //
 

    public GameObject IDCard;
    public GameObject IDCardPickUp;
    public int map = 0;
    public string mapName = "";
    // remind me to add a keycode for maps
    public static float money = 10f;
    public static int questPoints = 0;
    public static bool has_ID_Card = false;
    public static bool ID_Card_Delivered = false;


	// Use this for initialization
	void Start () {
        IDCard.GetComponent<Image>().enabled = false;
	}

    void Update ()
    {
        Debug.Log("has ID card " + has_ID_Card + "\n ID_Card_Delivered" + ID_Card_Delivered);
        IDCard = GameObject.Find("ID_Card_Texture");
        IDCardPickUp = GameObject.Find("ID_Card");
        if (map == 0)
        {
            mapName = "Nil";
        }
        else if (map == 1)
        {
            mapName = "Apartment";
        }
        else if (map == 2)
        {
            mapName = "Street";
        }
        else if (map == 3)
        {
            mapName = "University";
        }
        else
        {
            mapName = "Event";
        }

        if (has_ID_Card == true && ID_Card_Delivered == false)
        {
            IDCard.GetComponent<Image>().enabled = true;
            Debug.Log("has ID card");
        }
        else
            {
                IDCard.GetComponent<Image>().enabled = false;
            }
            if (TextWriter.ID_Girl_Spoken == true)
        {
            IDCardPickUp.renderer.enabled = true;
            IDCardPickUp.GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            IDCardPickUp.renderer.enabled=false;
            IDCardPickUp.GetComponent<BoxCollider2D>().enabled = false;
        }

    }

    void OnGUI()
    {
        GUI.Box(new Rect(220, 25, 150, 75), "Map: " + mapName, GUIStyle.none);
        GUI.Box(new Rect(220, 45, 150, 75), "Money: £" + money, GUIStyle.none);
		GUI.Box(new Rect(220, 65, 150, 75), "Quest Points: " + questPoints, GUIStyle.none);
        GUI.Box(new Rect(220, 10, 125, 125), "", GUIStyle.none);
    }

}
