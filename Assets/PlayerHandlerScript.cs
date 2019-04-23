using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandlerScript : MonoBehaviour
{
    public int points = 600;
    public Text score;
    public GameObject[] weapons;
    private GameObject firstweapon;
    private GameObject secondweapon;
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
                if (other.name == weapons[i].name)
                {
                    if (points >= weapons[i].GetComponent<WeaponsScript>().getcost())
                    {
                        for (int c = 0; c < transform.childCount; c++)
                        {
                            if (this.gameObject.transform.GetChild(i).gameObject.name == weapons[i].name)
                            {
                                if (!this.gameObject.transform.GetChild(i).gameObject.activeSelf)
                                {
                                    print("dit doet ie 2 keer");
                                    this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
                                    setPoints(Getpoints() - weapons[i].GetComponent<WeaponsScript>().getcost());
                                }
                                else if(this.gameObject.transform.GetChild(i).gameObject.activeSelf)
                                {
                                    this.gameObject.transform.GetChild(i).gameObject.GetComponent<PistolScript>().SetClip(this.gameObject.transform.GetChild(i).gameObject.GetComponent<PistolScript>().GetMaxClip());
                                    setPoints(Getpoints() - (weapons[i].GetComponent<WeaponsScript>().getcost() / 2));
                                    
                                }
                               
                            }
                        }
                    }
                    else if (points >= weapons[i].GetComponent<WeaponsScript>().getcost() / 2 && this.gameObject.transform.GetChild(i).gameObject.activeSelf)
                    {
                        for (int c = 0; c < transform.childCount; c++)
                        {
                            if (this.gameObject.transform.GetChild(i).gameObject.name == weapons[i].name)
                            {
                                
                                this.gameObject.transform.GetChild(i).gameObject.GetComponent<PistolScript>().SetClip(this.gameObject.transform.GetChild(i).gameObject.GetComponent<PistolScript>().GetMaxClip());
                                setPoints(Getpoints() - (weapons[i].GetComponent<WeaponsScript>().getcost() / 2));
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
