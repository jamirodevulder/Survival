using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour {
    public Transform goal;
    NavMeshAgent agent;
    private float healt = 100;
   
    // Use this for initialization
    void Start () {
         agent = GetComponent<NavMeshAgent>();
        
    }
	
	// Update is called once per frame
	void Update () {
            agent.destination = goal.position;
        

        if(healt <= 0)
        {
            Destroy(gameObject);
        }

        
    }


    public float gethealt()
    {
        return healt;
    }
    public void setHealt(float Healt)
    {
        healt = Healt;
    }
 
       
}
