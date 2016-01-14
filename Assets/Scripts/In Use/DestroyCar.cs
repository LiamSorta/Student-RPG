using UnityEngine;
using System.Collections;

public class DestroyCar : MonoBehaviour {
//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

	// Use this for initialization
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        CarsHandler.carCount -= 1;
    }
}
