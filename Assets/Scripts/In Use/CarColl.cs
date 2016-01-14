using UnityEngine;
using System.Collections;

public class CarColl : MonoBehaviour {

    //       ( \_/ )
    //      =( ^.^ )=
    //      (") _ (")
    // Code By Adam O'Connor


	// Use this for initialization
    void start()
    {

        
    }
	
	// Update is called once per frame
	void Update () {

	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "car1")
        {
            PlayerStats.energy -= 100;
            Achievements.hitByCar = true;
            Debug.Log("Hit");
            car1Move.Go1 = false;
        }
        if (other.transform.tag == "car2")
        {
            PlayerStats.energy -= 100;
            Achievements.hitByCar = true;
            Debug.Log("Hit");
            car2Move.Go2 = false;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "car1")
        {
            car1Move.Go1 = true;
        }
        if (other.transform.tag == "car2")
        {
            car2Move.Go2 = true;
        }
    }
}
