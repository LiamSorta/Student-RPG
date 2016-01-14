using UnityEngine;
using System.Collections;

public class CarSpawn1 : MonoBehaviour {

    //       ( \_/ )
    //      =( ^.^ )=
    //      (") _ (")
    // Code By Adam O'Connor

    public Transform point1;
	// Use this for initialization
	void Start () {

        GameObject Point1 = GameObject.Find("point1");
        point1 = Point1.transform;

        transform.position = new Vector3(point1.position.x, point1.position.y, point1.position.z);

	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
