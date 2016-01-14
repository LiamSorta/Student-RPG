using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    public GameObject selectText;                           //Prefab for text options.
    Text text;                                              //For quickly setting text.
    Animator animator;                                      //Grab animator.
    List<string> optionalText = new List<string>();         //String array to store chat options.
    private bool isActive;                                  //Is the chat window active?
    public string currentInteraction;                              //The current interaction going on.
    public string currentInteractionReply;                         //Reply of the current interaction.                                
    public bool animComplete;                               //Enabled when animation is complete.
    public bool hasClosed;                                  //Enabled when animation is closed.
    public AudioSource[] sounds;                            //Audio array
    public AudioSource openWindow;                          //for multiple
    public AudioSource select;                              //audio sources.
    public GameObject singleOption, multiOption1, multiOption2;//The objects used by the script.
    public bool diagStarted;                                //Independant bool for other scripts to use, idential to animcomplete and hasclosed but without delays.
    public bool heaterOn;                                   //Bool for multi-dialog object
    //code block by Adam O'Connor
    float crosstime = 3.0f;                                 //Time for "crossing lights"
    public static bool cross = false;                       // starts timer
    public GameObject StopCars;                             //Object fo crossing the road
    bool checkedBins = false;                               //bool for getting next dialogue on bins
    bool payForDrink = false;
    bool giveMoney = false;
    bool giveQuestPoints = false;
    //end of code block
    //Code by by Jamie Cox
    public bool Start12 = false;                             //Bool for starting the quiz
    public bool IsDone = false;                             //Quiz is done or not
    public bool taken = false;                              //Quiz is taken
    public bool Refused = false;                            //Quiz is refused
    //end of code block
    //Code by Josh Bannister
    public static bool ID_Girl_Spoken = false;                     //
    public bool given_Card = false;                         //
    public bool Easter_Suprise = false;                     //
    //end of code

	void Start () {
        //Initialization//
        hasClosed = true;
        text = GameObject.FindGameObjectWithTag("ChatText").GetComponent<Text>();
        animator = GetComponent<Animator>();
        sounds = GetComponents<AudioSource>();
        openWindow = sounds[0];
        select = sounds[1];

        
       
    }

    void Update()
    {
        
        if (!(currentInteractionReply == null))     //Transporting interaction when recieved
            SendMessage(currentInteraction,true);

    }

    void MISC(string item)  //Called when a misc message is recieved
    {
        if (!isActive && hasClosed == true)      //Only execute if a window is not currently active
        {
            openWindow.Play();
            animator.SetBool("isOpen", true);   //Start window animation
            diagStarted = true;
            hasClosed = false;

            //ALL INTERACTIONS HERE

            if (item == "PlayerDoor")
                PlayerDoor(false);
            if (item == "AndyDoor")
                AndyDoor(false);
            if (item == "MaxDoor")
                MaxDoor(false);
            if (item == "HollyDoor")
                HollyDoor(false);
            if (item == "ZoeDoor")
                ZoeDoor(false);
            if (item == "NoticeBoard")
                NoticeBoard(false);
            if (item == "PizzaSlice")
                Pizza(false);
            if (item == "Laptop")
                Laptop(false);
            if (item == "Heater" && heaterOn == false)
                Heater(false);
            else if(item == "Heater")
                HeaterOn(false);
            if (item == "Flatmate")
                Flatmate(false);
            //Code block by Adam O'Connor
            if (item == "DrinkVendor")
                DrinkVendor(false);
            if (item == "OtherVendor")
                OtherVendor(false);
            if (item == "SNPC1")
                SNPC1(false);
            if (item == "SNPC2")
                SNPC2(false);
            if (item == "SNPC3")
                SNPC3(false);
            if (item == "SNPC4")
                SNPC4(false);
            if (item == "HOBO")
                HOBO(false);
            if (item == "bin")
                bin(false);
            if (item == "minigamestart")
                startMinigame(false);
            if (item == "button")
                crossingLight(false);
            if (item == "timetable")
                Timetable(false);
            //End of code block
            //code block by Jamie Cox
            if (item == "Teacher")
                Teacher(false);
            if (item == "Girl")
                Girl(false);
            if (item == "boy")
                boy(false);
            //end of block
            //code block by Josh Bannister
            if (item == "ID_Girl")
                ID_Girl(false);
            if (item == "Barista")
                Barista(false);
            if (item == "Customer_A")
                Customer_A(false);
            if (item == "Customer_B")
                Customer_B(false);
            if (item == "Lecture_Door")
                Lecture_Door(false);
            //end of code block
        }
    }

    void MISCReply(string reply)
    {
        singleOption.gameObject.SetActive(false);  //Disable all dialog options when menu closing
        multiOption1.gameObject.SetActive(false);
        multiOption2.gameObject.SetActive(false);
        multiOption1.GetComponent<SelectedText>().isSelected = false;
        multiOption2.GetComponent<SelectedText>().isSelected = false;
     //
        GameObject.FindGameObjectWithTag("GM").SendMessage("Selected"); 
        currentInteractionReply = reply;
        animator.SetBool("isOpen", false);      //Starts close animation
        optionalText.Clear();                   //Clears array
        isActive = false;                       //Allows for another menu to be opened
        animComplete = false;
        diagStarted = false;

    }

    void DisplayOptions(List<string> textOptions)
    {
        bool firstSelected = true;              //Assigns first option to be selected first
        int multioption = 0;
        if (textOptions.Count == 1)
        {
            singleOption.gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("SingleOption").GetComponent<Text>().text = textOptions[0];

            if (firstSelected)
            {
                GameObject.FindGameObjectWithTag("SingleOption").SendMessage("Selected");
                firstSelected = false;
            }
        }
        else
        {
            multiOption1.gameObject.SetActive(true);
            multiOption2.gameObject.SetActive(true);
            foreach (string str in textOptions)
            {
                multioption++;
                //Instantiates new optional text, sets transforms as children of the current canvas and assigns their scales / respective text to display
                GameObject.FindGameObjectWithTag("MultiOption" + multioption).GetComponent<Text>().text = str;
                if (firstSelected)                      //For selecting first option to be selected by default
                {
                    GameObject.FindGameObjectWithTag("MultiOption" + multioption).SendMessage("Selected");
                    firstSelected = false;
                }
            }
        }
    }




    void PlayerDoor(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "PlayerDoor";
            text.text = "This is your room, would you like to enter?";
            optionalText.Add("Yes");
            optionalText.Add("No");
            DisplayOptions(optionalText);
            isActive = true;

        }
        else if (currentInteractionReply == "Yes")
                Application.LoadLevel("Room");
    }

    void Laptop(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "Laptop";
            text.text = "You open your laptop. Are you going to be productive?";
            optionalText.Add("(Study) Of course I am!");
            optionalText.Add("(Waste your time) Of course I am...");
            DisplayOptions(optionalText);
            isActive = true;

        }
        else if (currentInteractionReply == "(Study) Of course I am!")
        {
        }
            // Application.LoadLevel("Room");
    }

    void AndyDoor(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "AndyDoor";
            text.text = "This is Andy's Room, it's locked right now.";
            optionalText.Add("Ok");
            DisplayOptions(optionalText);
            isActive = true;
        }
        else if (currentInteractionReply == "Yes")
        {
            //Do something
        }
    }

    void MaxDoor(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "MaxDoor";
            text.text = "This is Max's Room, it's locked right now.";
            optionalText.Add("Ok");
            DisplayOptions(optionalText);
            isActive = true;
        }
        else if (currentInteractionReply == "Yes")
        {
            //Do something
        }
    }

    void HollyDoor(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "HollyDoor";
            text.text = "This is Holly's Room, it's locked right now.";
            optionalText.Add("Ok");
            DisplayOptions(optionalText);
            isActive = true;
        }
        else if (currentInteractionReply == "Yes")
        {
            //Do something
        }
    }

    void ZoeDoor(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "ZoeDoor";
            text.text = "This is Zoe's Room, it's locked right now.";
            optionalText.Add("Ok");
            DisplayOptions(optionalText);
            isActive = true;
        }
        else if (currentInteractionReply == "Yes")
        {
            //Do something
        }
    }

    void NoticeBoard(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "NoticeBoard";
            text.text = "The notice board reads: Hey, can you clean your *!@#!$# dishes for once? Thanks.";
            optionalText.Add("Sigh and walk away");
            DisplayOptions(optionalText);
            isActive = true;
        }
        else if (currentInteractionReply == "Yes")
        {
            //Do something
        }
    }

    void Heater(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "Heater";
            text.text = "You dial up the heat in the middle of summer. I'm sure your flatmates will appriciate that. #%&!.";
            GameObject.FindGameObjectWithTag("GM").SendMessage("TurnOnHeater");
            optionalText.Add("I'm sorry?");
            DisplayOptions(optionalText);
            GameObject.FindGameObjectWithTag("Heater").GetComponent<Animator>().SetBool("heaterOn", true);
            isActive = true;
            heaterOn = true;
        }
        else if (currentInteractionReply == "Yes")
        {
            //Do something
        }
    }

    void HeaterOn(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "HeaterOn";
            text.text = "Yeah... it can't turn off once it's been turned on. Good job.";
            optionalText.Add("Walk away.");
            DisplayOptions(optionalText);
            isActive = true;
            heaterOn = true;
        }
        else if (currentInteractionReply == "Yes")
        {
            //Do something
        }
    }


    void Pizza(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "Pizza";
            text.text = "Your flatmate is in their room and left their pizza unattended.";
            optionalText.Add("Steal a few slices");
            optionalText.Add("Leave it");
            DisplayOptions(optionalText);
            isActive = true;
        }
        else if (currentInteractionReply == "Steal a few slices")
        {
            GameObject.FindGameObjectWithTag("GM").SendMessage("PizzaEaten");
        }
    }
    void Flatmate(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "Flatmate";
            text.text = "HEY! DO YOU KNOW WHO STOLE MY PIZZA?!";
            optionalText.Add("(Your flatmate glares at you, expect a passive agressive month) Urm... No sorry, I have no idea.");
            DisplayOptions(optionalText);
            isActive = true;
        }
    }

    void AnimDone(string isDone)
    {
        if (isDone == "true")
            animComplete = true;
    }
    void HasClosed(string animClosed)
    {
        if (animClosed == "true")
            hasClosed = true;
    }
    void HeaterOn()
    {
        heaterOn = true;
    }

    //Code block by Adam O'Connor
    void DrinkVendor(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "DrinkVendor";
            text.text = "Would you like an Energy Drink £5";
            optionalText.Add("Yes");
            optionalText.Add("No");
            DisplayOptions(optionalText);
            isActive = true;
        }
        else if (currentInteractionReply == "Yes")
        {
            if(payForDrink == false)
            {
                payForDrink = true;
                Buggie_UI.money -= 5;
            }
          
        }
    }
    void OtherVendor(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "OtherVendor";
            text.text = "Sorry we are still setting up, come back later!";
            optionalText.Add("Leave");
            DisplayOptions(optionalText);
            isActive = true;
        }
    }
    void SNPC1(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "SNPC1";
            text.text = "I'm just an NPC, i don't have much to say";
            optionalText.Add("OK then...");
            DisplayOptions(optionalText);
            isActive = true;
        }
    }
    void SNPC2(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "SNPC2";
            text.text = "How weird would it be if WE were a game and all our actions were being controlled";
            optionalText.Add("Walk away slowly...");
            DisplayOptions(optionalText);
            isActive = true;
        }
    }
    void SNPC3(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "SNPC3";
            text.text = "The guy just stares at you";
            optionalText.Add("Walk away slowly...");
            DisplayOptions(optionalText);
            isActive = true;
        }
    }
        void SNPC4(bool isEnd)
    {
        if (!isEnd)
        {
            currentInteraction = "SNPC4";
            text.text = "'Sup";
            optionalText.Add("'Sup");
            DisplayOptions(optionalText);
            isActive = true;
        }
    }
        void HOBO(bool isEnd)
        {
            if (!isEnd)
            {
                currentInteraction = "HOBO";
                text.text = "Spare some change?";
                optionalText.Add("Yes");
                optionalText.Add("No");
                DisplayOptions(optionalText);
                isActive = true;
            }
            else if (currentInteractionReply == "Yes")
            {
                if(giveMoney == false)
                {
                    giveMoney = true;
                    Buggie_UI.money -= 1;
                }
            }
            
        }
        void bin(bool isEnd)
        {
            if (!isEnd && checkedBins == false)
            {
                currentInteraction = "bin";
                text.text = "It's a bin do you...";
                optionalText.Add("Go through it");
                optionalText.Add("Leave it alone");
                DisplayOptions(optionalText);
                isActive = true;
            }
            else if (currentInteractionReply == "Go through it")
            {
                checkedBins = true;
                
            }
            if (!isEnd && checkedBins == true)
            {
                currentInteraction = "bin";
                text.text = "That was disgusting.... and I didn't even find anything";
                optionalText.Add("Leave it alone");
                DisplayOptions(optionalText);
                isActive = true;
            }
        }
        void startMinigame(bool isEnd)
        {
            if (!isEnd)
            {
                currentInteraction = "minigamestart";
                text.text = "Hi! You've stepped through a portal and now are in a maze inhabited only by charity workers. Since you can't fight you're only choice is to avoid them and find the other portal";
                optionalText.Add("Umm..... Ok..");
                DisplayOptions(optionalText);
                isActive = true;
            }
        }
        void crossingLight(bool isEnd)
        {
            if (!isEnd)
            {
                currentInteraction = "button";
                text.text = "Push the button to cross";
                optionalText.Add("Push");
                optionalText.Add("Don't push");
                DisplayOptions(optionalText);
                isActive = true;
                StopCars.SetActive(true);
            }
            else if (currentInteractionReply == "Push")
            {


            }
        }
            void Timetable(bool isEnd)
        {
            if (!isEnd)
            {
                currentInteraction = "timetable";
                text.text = "You Check your lessons";
                optionalText.Add("Ok");
                DisplayOptions(optionalText);
                isActive = true;
                Achievements.readTimetable = true;
            }
            else if (currentInteractionReply == "Ok")
            {
              
            }

        }
    //End of code block
            //Jamie Cox's code Start

            void Teacher(bool isEnd)
            {
                if (!isEnd && IsDone == false & taken == false)
                {
                    currentInteraction = "Teacher";
                    text.text = "Would you like to take a test?";
                    optionalText.Add("Yup");
                    optionalText.Add("Nope");
                    DisplayOptions(optionalText);
                    isActive = true;
                }
                else if (currentInteractionReply == "Yup")
                {
                   
                    TDisable.tenabled = true;
                    Application.LoadLevel("Quiz");

                }
               

            }



            void Girl(bool isEnd)
            {
                if (!isEnd)
                {
                    currentInteraction = "Girl";
                    text.text = "People sure do love being late";
                    optionalText.Add("I'm sure they had a reason");
                    optionalText.Add("Yup lazy people");
                    DisplayOptions(optionalText);
                    isActive = true;
                    taken = true;

                }
            }
            void boy(bool isEnd)
            {
                if (!isEnd)
                {
                    currentInteraction = "boy";
                    text.text = "Hey C gets you a C if you know what i mean";
                    optionalText.Add("Wait what?");
                    DisplayOptions(optionalText);
                }
            }

    //Jamie Coxs code end
       //Code by Josh Bannister
            void ID_Girl(bool isEnd)
            {
                if (!isEnd && Buggie_UI.has_ID_Card == false && given_Card == false)
                {
                    currentInteraction = "ID_Girl";
                    text.text = "I've lost my ID Card! Can you help me?";
                    optionalText.Add("Sure!");
                    optionalText.Add("Sorry, I'm busy.");
                    DisplayOptions(optionalText);
                    isActive = true;
                }
                else if (currentInteractionReply == "Sure!")
                {
                    ID_Girl_Spoken = true;
                    Debug.Log(ID_Girl_Spoken);
                }
                if (!isEnd && Buggie_UI.has_ID_Card == true && ID_Girl_Spoken == true)
                {
                    currentInteraction = "ID_Girl";
                    text.text = "You've found my ID Card! Thank you!";
                    optionalText.Add("You're welcome.");
                    DisplayOptions(optionalText);
                    isActive = true;
                    Buggie_UI.ID_Card_Delivered = true;
                    Buggie_UI.has_ID_Card = false;
                }
                else if (currentInteractionReply == "You're welcome.")
                {
                    given_Card = true;
                    if(giveQuestPoints == false)
                    {
                        giveQuestPoints = true;
                        Buggie_UI.questPoints += 50;
                    }
                }
                if (!isEnd && given_Card == true)
                {
                    currentInteraction = "ID_Girl";
                    text.text = "Thank you for helping me earlier!";
                    optionalText.Add("No problem.");
                    DisplayOptions(optionalText);
                    isActive = true;
                }
            }

            void Lecture_Door(bool isEnd)
            {
                if (!isEnd)
                {
                    currentInteraction = "Lecture_Door";
                    text.text = "There's an exam going on, best not disturb them.";
                    optionalText.Add("OK");
                    DisplayOptions(optionalText);
                    isActive = true;
                }
            }

            void Barista(bool isEnd)
            {
                if (!isEnd && Easter_Suprise == false)
                {
                    currentInteraction = "Barista";
                    text.text = "Welcome to 8/6 Kafe!";
                    optionalText.Add("Isn't it supposed to be 6/8?");
                    DisplayOptions(optionalText);
                    isActive = true;
                }
                else if (currentInteractionReply == "Isn't it supposed to be 6/8?")
                {
                    Easter_Suprise = true;
                }
                if (!isEnd && Easter_Suprise == true)
                {
                    currentInteraction = "Barista";
                    text.text = "Shh, don't let them hear you!";
                    optionalText.Add("...");
                    DisplayOptions(optionalText);
                    isActive = true;
                }
            }

            void Customer_A(bool isEnd)
            {
                if (!isEnd)
                {
                    currentInteraction = "Customer_A";
                    text.text = "Man these smarty-cookies are good!";
                    optionalText.Add("Coolio");
                    DisplayOptions(optionalText);
                    isActive = true;
                }
            }

            void Customer_B(bool isEnd)
            {
                if (!isEnd)
                {
                    currentInteraction = "Customer_B";
                    text.text = "I'll never leave pizza out again.";
                    optionalText.Add("It's a cruel world, man.");
                    DisplayOptions(optionalText);
                    isActive = true;
                }
            }
    //end of Code
}

