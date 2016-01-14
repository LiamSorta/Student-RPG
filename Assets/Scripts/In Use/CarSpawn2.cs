using UnityEngine;
using System.Collections;

public class CarSpawn2 : MonoBehaviour {

    //       ( \_/ )
    //      =( ^.^ )=
    //      (") _ (")
    // Code By Adam O'Connor

    public Transform point2;
	// Use this for initialization
	void Start () {

        GameObject Point2 = GameObject.Find("point2");
        point2 = Point2.transform;

        transform.position = new Vector3(point2.position.x, point2.position.y, point2.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        


	}
}
