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
        for (int i = 1; i < mapwidth; i++)
        {
            for (int j = 0; j < mapheight; j++)
            {


                GameObject hx_go = (GameObject) Instantiate(hexPrefab, center, Quaternion.identity);
               
                hx_go.name = "Position_" + i + "_" + j;
                hx_go.transform.SetParent(this.transform);
                hx_go.isStatic = true;
          
                center.x = center.x + width;
                
               
            }
            center.z = center.z + height;


            if (i % 2 == 0)
            {
                Debug.Log(i % 2);
                center.x = 0;
            }           
            else
            {
                Debug.Log(i % 2);
                center.x = width / 2;
            }
                
        }

        }

        

        

        

}
