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
            GameObject ourHitObject = hitInfo.collider.gameObject;
            Color col = new Color(54.0f,115.0f,123.0f,1.0f);

            Debug.Log("Raycast hit:" + ourHitObject.name);
            if (Input.GetMouseButtonDown(0))
            {
                MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer>();
                
                if (mr.material.color == Color.red)
                {
                    mr.material.color = col; 
                }
                else
                {
                    mr.material.color = Color.red;
                }
            }
        }
        


    }
}
