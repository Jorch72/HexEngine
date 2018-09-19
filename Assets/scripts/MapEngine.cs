using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapEngine: MonoBehaviour
{
    public GameObject hexPrefab;
    bool flat_topped = true;

    Vector3[] corners = new Vector3[6];
    float width;
    float height;

   
    void Start()
    {
        int mapwidth = 32;
        int mapheight = 32;
        float size = 0.88f;

        width = 2 * size;
        height = Mathf.Sqrt(3) * size;
          
        Vector3 center = new Vector3(0, 0, 0);
        for (int R = 1; R < mapwidth; R++)
        {
            for (int Q = 0; Q < mapheight; Q++)
            {


                GameObject hx_go = (GameObject) Instantiate(hexPrefab, center, Quaternion.identity);
               
                hx_go.name = "Row_" + R + "_Column_" + Q;
                hx_go.GetComponent<Hex>().R = R;
                hx_go.GetComponent<Hex>().Q = Q;

                //Parent this hex
                hx_go.transform.SetParent(this.transform);
                hx_go.isStatic = true;
          
                center.x = center.x + width;
                
               
            }
            center.z = center.z + height;


            if (R % 2 == 0)
            {
                Debug.Log(R % 2);
                center.x = 0;
            }           
            else
            {
                Debug.Log(R % 2);
                center.x = width / 2;
            }
                
        }

        }

        

        

        

}
