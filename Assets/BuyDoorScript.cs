using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyDoorScript : MonoBehaviour {
    public int cost;
    private GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                int money = player.GetComponent<PlayerHandlerScript>().Getpoints();
                    if(money >= cost)
                    {
                    gameObject.SetActive(false);
                    player.GetComponent<PlayerHandlerScript>().setPoints(money - cost);
                    }
            }
        }
    }
}
