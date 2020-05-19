using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour {
    public KeyCode jump;
    public KeyCode foward;
    public Rigidbody z;
    public Vector3 x;
    public Vector3 y;
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (jump)) {
            Debug.Log ("Jump taste wurde gedrückt");
            z.AddForce (x);
        }

        if (Input.GetKeyDown (foward)) {
            Debug.Log ("Forwärts taste wurde gedrückt");
            z.AddForce (y);

        }
    }
}