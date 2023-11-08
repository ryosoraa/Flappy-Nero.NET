using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeroScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody2D;
    public float floatStreght;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D.gravityScale = 2;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) == true) {
            myRigidbody2D.velocity = Vector2.up * floatStreght;
        }
        
    }
}
