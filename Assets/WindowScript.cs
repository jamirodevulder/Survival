using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour {
    public float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemie")
        {
            for(int i = 0; i < transform.childCount; i++)
            {
                
                if (this.gameObject.transform.GetChild(i).gameObject.activeSelf)
                {
                    
                  
                }

            }
            //print(this.gameObject.transform.GetChild(0).name);\
            print(transform.childCount);
        }
    }
}
