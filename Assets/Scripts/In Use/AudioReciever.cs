using UnityEngine;
using System.Collections;

public class AudioReciever : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////


    //Declaring array to allow for multiple audio sources on same object
    public AudioSource[] sounds;
    AudioSource bgTrack;
    AudioSource select;
    AudioSource bgTrack2;
    AudioSource bgTrack3;
    bool bg2Play = false;
    bool bg1Play = true;
    bool bg3Play = false;

    void Start()
    {
        //Assigning the variables to the sounds
        bgTrack = sounds[0];
        select = sounds[1];
        bgTrack2 = sounds[2];
        bgTrack3 = sounds[3];
    }

    void OnLevelWasLoaded()
    {
        Debug.Log(Application.loadedLevelName);
        if(Application.loadedLevelName == "Hall" && bg1Play == false)
        {
            
            bgTrack.Play();
            bgTrack2.Stop();
            bgTrack3.Stop();
            bg2Play = false;
            bg1Play = true;
            bg3Play = false;
        }
        if (Application.loadedLevelName  == "Street" && bg2Play == false)
        {
            bgTrack.Stop();
            bgTrack2.Play();
            bgTrack3.Stop();
            bg2Play = true;
            bg1Play = false;
            bg3Play = false;
        }
        if (Application.loadedLevelName == "Uni" && bg2Play == false)
        {
            bgTrack.Stop();
            bgTrack2.Play();
            bgTrack3.Stop();
            bg2Play = true;
            bg1Play = false;
            bg3Play = false;
        }
        if (Application.loadedLevelName == "Classroom" && bg3Play == false)
        {
            bgTrack.Stop();
            bgTrack2.Stop();
            bgTrack3.Play();
            bg2Play = false;
            bg1Play = false;
            bg3Play = true;
        }
        if (Application.loadedLevelName == "Cafe" && bg2Play == false)
        {
            bgTrack.Stop();
            bgTrack2.Play();
            bgTrack3.Stop();
            bg2Play = true;
            bg1Play = false;
            bg3Play = false;
        }
        if (Application.loadedLevelName == "charity_minigame" && bg3Play == false)
        {
            bgTrack.Stop();
            bgTrack2.Stop();
            bgTrack3.Play();
            bg2Play = false;
            bg1Play = false;
            bg3Play = true;
        }

    }


    void Selected()
    {
        select.Play();
    }
}
