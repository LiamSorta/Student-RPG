using UnityEngine;
using System.Collections;

public class CarsHandler : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    float last_spawn_time = -100;
    float next_spawn_time = 3;
    public Transform car_prefab;
    public Transform car1_prefab;
    public static int carCount;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
    {

        if (Time.time - last_spawn_time > next_spawn_time && carCount < 5)
        {
            next_spawn_time = Random.Range(2,5);
            last_spawn_time = Time.time;

            if (Random.Range(1, 10) % 2 == 1)
            {
                Instantiate(car_prefab);
                carCount += 1;
            }
            if (Random.Range(1, 10) % 2 == 0)
            {
                Instantiate(car1_prefab);
                carCount += 1;
            }
        }
	}



}
