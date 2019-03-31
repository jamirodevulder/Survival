using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float movementspeed = 10f;
    public bool backwards;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Vertical") == 1)
        {
            var z = Input.GetAxis("Vertical") * Time.deltaTime * movementspeed;
            transform.Translate(0, 0, z);
        }




    }
}
