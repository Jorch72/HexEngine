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

    public readonly int Q;
    public readonly int R;
    public readonly int S;
    readonly float WIDTH_MULTIPLIER = Mathf.Sqrt(3) / 2;


    float radius = 1.05f;
    bool allowWrapEastWest = true;
    bool allowWrapNorthSouth = false; // check stupid area

    public Vector3 Position()
    {
        if (R % 2 == 0)
        {
            return new Vector3(
                        HexHorizontalSpacing() * (this.Q + this.R / 2),
                        0,
                        HexVerticalSpacing() * this.R
                        );
        }
        else
        {
            return new Vector3(
                        HexHorizontalSpacing() * (this.Q + this.R / 2) + HexHorizontalSpacing() / 2,
                        0,
                        HexVerticalSpacing() * this.R
                        );
        }
    }

    public Vector3 PositionFromCamera(Vector3 cameraPosition, float mapRows, float mapColumns)
    {
        float mapHeight = mapRows * HexVerticalSpacing();
        float mapwidth = mapColumns * HexHorizontalSpacing();

        Vector3 position = Position();

        
        if (allowWrapEastWest)
        {
            float howManyWidthsFromCamera = (position.x - cameraPosition.x) / mapwidth;
            if (Mathf.Abs(howManyWidthsFromCamera) <= 0.5f)
            {
                return position;
            }

            if (howManyWidthsFromCamera > 0)
                howManyWidthsFromCamera += 0.5f;
            else
                howManyWidthsFromCamera -= 0.5f;

            int howManyWidthsTooFix = (int)howManyWidthsFromCamera;

            position.x -= howManyWidthsTooFix * mapwidth;
        }

        if (allowWrapNorthSouth)
        {
            float howManyHeightsFromCamera = (position.z - cameraPosition.z) / mapHeight;

            if (howManyHeightsFromCamera > 0)
                howManyHeightsFromCamera += 0.5f;
            else
                howManyHeightsFromCamera -= 0.5f;

            int howManyHeightsTooFix = (int)howManyHeightsFromCamera;

            position.z -= howManyHeightsTooFix * mapHeight;
        }

        return position;
    }

    float HexHeight()
    {
        return radius * 2;
    }

    float HexWidth()
    {
        return WIDTH_MULTIPLIER * HexHeight();
    }

    float HexVerticalSpacing()
    {
        return HexHeight() * 0.75f;
    }

    float HexHorizontalSpacing()
    {
        return HexWidth();
    }

   


    
}
