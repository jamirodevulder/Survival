using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandlerScript : MonoBehaviour
{
    private int points = 100;
    public Text score;
    public GameObject[] weapons;
    // Use this for initialization
    void Start()
    {
        setPoints(Getpoints());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            for(int i = 0; i < weapons.Length; i++)
            {
                if(other.name == weapons[i].name)
                {
                    if(points >= weapons[i].GetComponent<WeaponsScript>().getcost())
                    {
                        for(int c = 0; c < transform.childCount; c++)
                        {
                            if (this.gameObject.transform.GetChild(i).gameObject.name == weapons[i].name)
                            {

                                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
                                setPoints(Getpoints() - weapons[i].GetComponent<WeaponsScript>().getcost());
                            }
                        }
                    }
                }
            }
        }
    }


    public int Getpoints()
    {
        return points;
    }
    public void setPoints(int Points)
    {
        points = Points;
        score.text = "Points: " + points;
    }
}
