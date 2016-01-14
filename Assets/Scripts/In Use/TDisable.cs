//Jamie
using UnityEngine;
using System.Collections;

public class TDisable : MonoBehaviour {

    //Jamie Cox
	public static bool tenabled = false; 
	// Use this for initialization
	void Start () {
	



	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.Log (tenabled);

		if(tenabled == true){
			Destroy(gameObject);
		}

		else{
			gameObject.SetActive (true);
		}


	}
}
