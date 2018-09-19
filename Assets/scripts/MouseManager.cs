using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.Log("Mouseposition: " + Input.mousePosition);

        //
        //GameObject.Find("Camera Bob").GetComponent<Camera>();
        // In orthographic mode
        //Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log("World Point: " + worldPoint);
        RaycastHit hitInfo;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo))
        {
            //Debug.Log("Raycast hit:" + hitInfo.collider.gameObject.name);
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Hej");
            }
        }
        


    }
}
