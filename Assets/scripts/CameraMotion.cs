using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour {
    Vector3 oldPosition;

	// Use this for initialization
	void Start () {
        oldPosition = this.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
        //Click and move
        //WASD
        CheckIfCameraMoved();
	}

    public void PanToHex(Hex Hex)
    {
        // move camera to Hex
    }

    void CheckIfCameraMoved()
    {
        if (oldPosition != this.transform.position)
        {
            // Camera moved
            oldPosition = this.transform.position;

            HexComponent[] hexes = GameObject.FindObjectsOfType<HexComponent>();
            foreach (HexComponent hex in hexes)
            {
                hex.UpdatePosition();
            }

        }
    }

}
