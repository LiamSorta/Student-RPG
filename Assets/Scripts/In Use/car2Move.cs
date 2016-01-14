using UnityEngine;
using System.Collections;

public class car2Move : MonoBehaviour
{

    //       ( \_/ )
    //      =( ^.^ )=
    //      (") _ (")
    // Code By Adam O'Connor

    public static bool Go2 = true;
    private bool nRigidbody = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Go2 == true)
        {
            if (nRigidbody == true)
            {
                Rigidbody2D Addrigidbody2 = gameObject.AddComponent<Rigidbody2D>();
                Addrigidbody2.fixedAngle = true;
                Addrigidbody2.gravityScale = 0;
                nRigidbody = false;
                
            }
            gameObject.rigidbody2D.AddForce(Vector3.left * 750, 0);
        }
        if (Go2 == false)
        {
            Destroy(gameObject.rigidbody2D);
            nRigidbody = true;
        }

    }
}
