using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapEngine: MonoBehaviour
{
    public GameObject hexPrefab;

    float width;
    float height;

   
    void Start()
    {
        int mapwidth = 4;
        int mapheight = 4;
        //float size = 0.88f;

        //width = 2 * size;
        //height = Mathf.Sqrt(3) * size;
        int Q;
        int R;
        //Vector3 center = new Vector3(0, 0, 0);

        for (Q = 0; Q < mapwidth; Q++)
        {
            for (R = 0; R < mapheight; R++)
            {

                //Debug.Log("1Center X: " + center.x + " Center Z: " + center.z + " Row: " + R + " Column: " + Q);
                //GameObject hx_go = (GameObject) Instantiate(hexPrefab, center, Quaternion.identity,this.transform);
                GameObject hx_go = (GameObject)Instantiate(
                    hexPrefab, 
                    new Vector3(Q,0,R), 
                    Quaternion.identity, 
                    this.transform);
                //hx_go.name = "Row_" + R + "_Column_" + Q;
                hx_go.GetComponent<Hex>().R = R;
                hx_go.GetComponent<Hex>().Q = Q;

                //Parent this hex
                hx_go.transform.SetParent(this.transform);
                hx_go.isStatic = true;
          
                //center.x = center.x + width;
                
               
            }        
            //center.z = center.z + height;

            if (R % 2 == 0)
            {
                
                //center.x = 0;
            }           
            else
            {
                
                //center.x = width / 2;
            }
                
        }

        }
}
