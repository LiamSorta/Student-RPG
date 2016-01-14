using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    float windowTimer = 3f;

    //List of achievements
    public static bool wakeUp = false;
    public static bool readTimetable = false;
    public static bool leaveAccom = false;
    public static bool goToBed = false;
    public static bool failCharityGame = false;
    public static bool winCharityGame = false;
    public static bool hitByCar = false;
    public static bool attendClass = false;
    public static bool goTwice = false;
    public static bool getAFirst = false;
    public static bool failTheClass = false;
    public static bool fastCharity = false;
    bool wakeUpComplete = false;
    bool readTimetableComplete = false;
    bool leaveAccomComplete = false;
    bool goToBedComplete = false;
    bool failCharityGameComplete = false;
    bool winCharityGameComplete = false;
    bool hitByCarComplete = false;
    bool attendClassComplete = false;
    bool goTwiceComplete = false;
    bool getAFirstComplete = false;
    bool failTheClassComplete = false;
    bool fastCharityComplete = false;


    // Use this for initialization

    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {       
        if (windowTimer < 0)
        {
            windowTimer = 3f;
        }

        if (Application.loadedLevelName == "Street")
        {
            leaveAccom = true;
        }
    }

    void OnGUI()
    {
        if (wakeUp && wakeUpComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n New Day");
            if (windowTimer < 0)
            {
                wakeUpComplete = true;
            }
        }

        if (leaveAccom && leaveAccomComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n Fresh Air");
            if (windowTimer < 0)
            {
                leaveAccomComplete = true;
            }
        }

        if (readTimetable && readTimetableComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n Plan For The Day");
            if (windowTimer < 0)
            {
                readTimetableComplete = true;
            }
        }

        if (goToBed && goToBedComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n Sleepy");
            if (windowTimer < 0)
            {
                goToBedComplete = true;
            }
        }

        if (failCharityGame && failCharityGameComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n \"Generous\"");
            if (windowTimer < 0)
            {
                failCharityGameComplete = true;
            }
        }

        if (winCharityGame && winCharityGameComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n Tight Fisted");
            if (windowTimer < 0)
            {
                winCharityGameComplete = true;
            }
        }

        if (hitByCar && hitByCarComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n How is that an achievement?!");
            if (windowTimer < 0)
            {
                hitByCarComplete = true;
            }
        }

        
        if (attendClass&& goTwiceComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n Studious");
            if (windowTimer < 0)
            {
                attendClassComplete = true;
            }
        }

        if (getAFirst && getAFirstComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n Overachiever");
            if (windowTimer < 0)
            {
                getAFirstComplete = true;
            }
        }

        if (failTheClass && failTheClassComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n At least you tried");
            if (windowTimer < 0)
            {
                failTheClassComplete = true;
            }
        }

        if (fastCharity && fastCharityComplete == false)
        {
            windowTimer -= Time.deltaTime;
            GUI.Box(new Rect(Screen.width / 3, 1, 250, 60), "Achievement Unlocked \n Fast Charity");
            if (windowTimer < 0)
            {
                fastCharityComplete = true;
            }
        }
    }
}
