using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
public class LookAtMouseScript : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();

    }

    // Update is called once per frame
    void Update()
    {



        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if (groundPlane.Raycast(cameraRay, out rayLength))
        {

            Vector3 pointToLook = new Vector3(cameraRay.GetPoint(rayLength).x, player.transform.position.y, cameraRay.GetPoint(rayLength).z);
            transform.LookAt(pointToLook);

        }




    }
}