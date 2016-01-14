using UnityEngine;
using System.Collections;

public class LaptopHandler : MonoBehaviour {


    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    TextWriter textWriter;
    public GameObject laptopOpen;
    AudioSource[] audioClips;
    void Start()
    {
        audioClips = FindObjectsOfType<AudioSource>() as AudioSource[];
        audioClips[1].volume = 1;
    }

    void Update()
    {
        textWriter = GameObject.FindGameObjectWithTag("InteractChat").GetComponent<TextWriter>();

        if (textWriter.diagStarted && textWriter.currentInteraction == "Laptop")
            laptopOpen.SetActive(true);
        else
            laptopOpen.SetActive(false);
    }
}
