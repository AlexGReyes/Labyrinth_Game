using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed;
    private Rigidbody rigb;
    //public GameObject p;  // panel
    //public GameObject player; //player

    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody>();
        //player.transform.position = new Vector3(-26.4f, 1.42f, 6.8f);
        //p.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);
        rigb.AddForce(movement * speed);
    }
}
