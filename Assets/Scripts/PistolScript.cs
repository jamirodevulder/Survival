using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolScript : MonoBehaviour {

    // Use this for initialization
    public GameObject bullit;
    public GameObject bulletspawn;
    private GameObject player;
    public int ammo;
    public int maxAmountOfBullits;
    public int clip;
    public int maxclip;
    // Use this for initialization
    void Start()
    {
       
        player = GameObject.Find("player");
        clip = maxclip;
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;


        layerMask = ~layerMask;
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask) || !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
            {
                if (ammo > 0)
                {
                    ammo = ammo - 1;
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                    Instantiate(bullit, new Vector3(bulletspawn.transform.position.x, bulletspawn.transform.position.y, bulletspawn.transform.position.z), player.transform.rotation);
                    Debug.Log(new Vector3(bulletspawn.transform.position.x, bulletspawn.transform.position.y, bulletspawn.transform.position.z));
                }
            }
           

          

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (clip > 0)
            {
                for (int i = 0; i < maxAmountOfBullits; i++)
                {
                    if (clip > 0 && ammo < maxAmountOfBullits)
                    {
                        ammo = ammo + 1;
                        clip = clip - 1;
                    }
                }
            }
        }


       


    }
    public void SetClip(int Clip)
    {
        clip = Clip;
    }
    public int GetMaxClip()
    {
        return maxclip;
    }
}

