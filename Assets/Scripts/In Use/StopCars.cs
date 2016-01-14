using UnityEngine;
using System.Collections;

public class StopCars : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor


    float crosstime = 6.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
            if (crosstime > 0)
            {

                crosstime -= Time.deltaTime;
                Debug.Log("Crosstime " + crosstime);
            }
            if (crosstime < 0)
            {
                gameObject.SetActive(false);
                TextWriter.cross = false;
                crosstime = 6.0f;
            }
        
            
	}
}
