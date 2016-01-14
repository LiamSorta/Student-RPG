using UnityEngine;
using System.Collections;

public class Reflection : MonoBehaviour {


//       ( \_/ )
//      =( ^.^ )=
//      (") _ (")
// Code By Adam O'Connor

    Vector2 rLineStart, rLineEnd;
    Animator anim;
    public Rigidbody2D Reflection_Prefab;
    public Transform Player;
    public static bool reflect = false;
    

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Code by Liam Biddle and edited to suit need by Adam O'Connor
        rLineStart = new Vector2(transform.position.x, (transform.position.y - (GetComponent<SpriteRenderer>().bounds.extents.y / 2))); //starts in centre of character
        rLineEnd = new Vector2(0, 20);

        RaycastHit2D hit = Physics2D.Raycast(rLineStart, rLineEnd, 10f, 1 << LayerMask.NameToLayer("Window")); // casting, length of 2
        Debug.DrawRay(rLineStart, new Vector3(0, 20), Color.red);

        if(hit && reflect == false)
        {
            Rigidbody2D Reflect = Instantiate(Reflection_Prefab, new Vector3(Player.position.x, Player.position.y+10,Player.position.z),Quaternion.identity) as Rigidbody2D;
            reflect = true;
            Debug.Log("Window");
        }
        if (!hit)
        {
            reflect = false;
        }
	}
}
