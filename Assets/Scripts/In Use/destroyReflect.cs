using UnityEngine;
using System.Collections;

public class destroyReflect : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Reflection.reflect == false)
        {
            Destroy(this.gameObject);
        }
	}
}
