using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour {
    ///////////////////////////
    //*                     *//
    //*    ~ Code by ~      *//
    //*    Liam Biddle      *//
    //* www.liamsorta.co.uk *//
    //*                     *//
    ///////////////////////////

    string password;
    public string code;
    public InputField inputField;
    public GameObject accessDenied;

    public void LogIn()
    {
        password = inputField.text;
        if (password == code)
            Application.LoadLevel(1);
        else
            accessDenied.SetActive(true);
    }
	
}
