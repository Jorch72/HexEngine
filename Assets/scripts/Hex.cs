using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex {

    public Hex(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = -(q + r);
    }

    public readonly int R;
    public readonly int Q;
    public readonly int S;

    // Q + R + S = 0

    static readonly float HEIGHT_MULTIPLIER = Mathf.Sqrt(3) / 2;

    public Vector3 Position()
    {
        float size = 1.0f;
        float width = 2 * size;
        float height = Mathf.Sqrt(3) * 2;

        //float radius = 1.0f;
        //float width = 2 * radius;
        //float height = HEIGHT_MULTIPLIER * width;

        float vert = height * 0.75f;
        float horiz = width;
        return new Vector3(horiz * (this.Q + this.R/2f), 0, vert * this.R);
    }
    public Hex[] GetNeighbours()
    {
        return null;
    }
	// Use this for initialization
	void Start () {
        
		
	}
	
}
