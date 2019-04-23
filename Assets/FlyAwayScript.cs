using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAwayScript : MonoBehaviour {
    private GameObject player;
    private bool fly = false;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        if (fly)
        {
            transform.position += new Vector3(-5, 5, -5) * Time.deltaTime;
        }
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                fly = true;
            }
        }
    }

}
