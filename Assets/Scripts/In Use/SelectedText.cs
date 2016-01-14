using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectedText : MonoBehaviour {

    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

	public bool isSelected;
    public GameObject interactSample;
    GameObject interactText;
    bool canSelect;

	void Update () {
        interactText = GameObject.FindGameObjectWithTag("InteractChat");

        if (isSelected)
        {
            GetComponent<Text>().color = Color.white;              //If the text is currently selected, highlight it in white
            transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);  //Enlarge the text for clairty
        }
        else
        {
            Color lowAlpha;
            lowAlpha = Color.white;
            lowAlpha.a = 0.5f;                              //Creating a new colour with a low alpha (transparency)
            GetComponent<Text>().color = lowAlpha;          //Setting the non-selected text to opaque for clairty
            transform.localScale = new Vector3(1, 1, 1);    //Setting scale back to 1,1,1 to prevent duplicate 1.2 size text
        }
        if (interactText.GetComponent<TextWriter>().animComplete)
        {
            if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) && (interactSample.activeInHierarchy))   //Reverse active setting of text
            {
                audio.Play();
                isSelected = !isSelected;
            }
            if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.KeypadEnter)))
            {
                if (isSelected)
                    GameObject.FindGameObjectWithTag("InteractChat").SendMessage("MISCReply", GetComponent<Text>().text);  //Relay back to chat object
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                
                GameObject.FindGameObjectWithTag("InteractChat").SendMessage("MISCReply", "Cancel");
            }
        }
	}

    void Selected()
    {
        isSelected = true;  //Called from the textwriter class to set an initialized text component due to prefabbing
    }
}
