using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BullitMovementScript : MonoBehaviour {
    public float speed;
    private GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {  
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "enemie")
        {
            Debug.Log("test");
            collision.gameObject.GetComponent<EnemyMovement>().setHealt(collision.gameObject.GetComponent<EnemyMovement>().gethealt() - 10);
            player.GetComponent<PlayerHandlerScript>().setPoints(player.GetComponent<PlayerHandlerScript>().Getpoints() + 10);
            Destroy(gameObject);
        }
    }
}
