using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseManager : MonoBehaviour {
    Movable selectedMovable;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        // Is ove Unity UI object
        //if (EventSystem.current.IsPointerOverGameObject())
        //{
        //    return;
        //}

        RaycastHit hitInfo;
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject ourHitObject = hitInfo.collider.gameObject;

            if (ourHitObject.GetComponent<Hex>() != null)
            {
                MouseOverHex(ourHitObject);
            }
            else if (ourHitObject.GetComponent<Movable>() != null)
            {
                Debug.Log("Movable");
                MouseOverMovable(ourHitObject);
            }


        }
    }

    void MouseOverHex(GameObject ourHitObject)
    {
        if (Input.GetMouseButtonDown(0))
        {
            MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer>();

            if (mr.material.color == Color.red)
            {
                mr.material.color = Color.gray;
            }
            else
            {
                mr.material.color = Color.red;
            }

            if (selectedMovable != null)
            {
                selectedMovable.destination = ourHitObject.transform.position;
            }
        }
    }

    void MouseOverMovable(GameObject ourHitObject)
    {
        if (Input.GetMouseButtonDown(0))
        {
            selectedMovable = ourHitObject.GetComponent<Movable>();
        }
    }
}
