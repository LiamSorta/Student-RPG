using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WakeUp : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////



    public Sprite a, d;

    private float energy;
    private bool currentKey; //True = D || False = A
    private bool endUI;
    private float lOrR;
	private AudioSource[] audioClips;

    
    void Start () {
        audioClips = FindObjectsOfType<AudioSource>() as AudioSource[];
        audioClips[1].volume = 0;

        lOrR = Random.Range(0, 1f);
        if (lOrR > 0.5f)                                                                                             // Makes either the left or
        {                                                                                                            // right arrow key box be set.
            GameObject.FindGameObjectWithTag("RightBox").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);       // Each side has a 50% chance to be chosen.
            currentKey = false;                                                                                      // Float between 0 and 1.
            GameObject.FindGameObjectWithTag("ADDetect").GetComponent<Image>().sprite = d;
        }                                                                                                            
        else
        {                                                                                                            
            GameObject.FindGameObjectWithTag("LeftBox").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            currentKey = true;
            GameObject.FindGameObjectWithTag("ADDetect").GetComponent<Image>().sprite = a;
        }
	}
	
	void Update () {
        
        Color lowerAlpha;
        lowerAlpha = Color.black;
        lowerAlpha.a = 1 - energy / 100f;
        GetComponent<SpriteRenderer>().color = lowerAlpha;

        float max = 95.17f;
        float min = 50f;

        GameObject.FindGameObjectWithTag("ADDetect").GetComponent<Image>().color = new Color(0,0,0,lowerAlpha.a - ((energy / 100)*3.5f));
        Camera.main.orthographicSize = min + (max / (max - min) * (energy / 5)) ;
        
            //goal = 95.17
        if (energy < 100) //Only execute if the energy hasn't exceeded 100 (max)
        {
            if (currentKey) //If the last key pressed was A, require D etc
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    GameObject.FindGameObjectWithTag("ADDetect").GetComponent<Image>().sprite = d;
                    GameObject.FindGameObjectWithTag("RightBox").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                    GameObject.FindGameObjectWithTag("LeftBox").transform.localScale = new Vector3(1, 1, 1f);
                    currentKey = !currentKey;
                    energy++;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    GameObject.FindGameObjectWithTag("ADDetect").GetComponent<Image>().sprite = a;
                    GameObject.FindGameObjectWithTag("LeftBox").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                    GameObject.FindGameObjectWithTag("RightBox").transform.localScale = new Vector3(1, 1, 1f);
                    currentKey = !currentKey;
                    energy++;
                }
            }
        }


        if(energy > 0 && energy < 100)  //Slowly deteriate energy
            energy -= Random.Range(0, 11f * Time.deltaTime);
        if (energy < 0) //Ensures energy never goes below 0
            energy = 0;
        //GameObject.FindGameObjectWithTag("TextBox").GetComponent<Text>().text = energy + "/100"; //Writes the energy to the text
        Debug.Log(energy + "/100");
        if (!endUI) //Once 100 has been hit, don't execute this again
        {
            if (energy > 100)
            {
                Debug.Log("u dun sun");
                endUI = true;
                Application.LoadLevel("Room");
            }
        }
	}
}
