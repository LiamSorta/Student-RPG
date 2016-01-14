using UnityEngine;
using System.Collections;

public class charityWorker : MonoBehaviour {

//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    public Transform[] movePoints;
    public float moveSpeed;
    private int currentPoint;

	// Use this for initialization
	void Start () {
        transform.position = movePoints[0].position;
        currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position == movePoints[currentPoint].position)
        {
            currentPoint ++;
        }

        if (currentPoint >= movePoints.Length)
        {
            currentPoint = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, movePoints[currentPoint].position, moveSpeed * Time.deltaTime);
	}
}
