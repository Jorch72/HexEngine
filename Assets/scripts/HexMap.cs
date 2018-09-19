using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HexMap: MonoBehaviour
{
    public GameObject hexPrefab;
    bool flat_topped = true;

    Vector3[] corners = new Vector3[6];
    float width;
    float height;

   
    void Start()
    {
        int mapRows = 5;
        int mapColumns = 10;

        float size = 0.88f;
        Debug.Log("MOD: " + 0 % 2);
        width = 2 * size;
        height = Mathf.Sqrt(3) * size;
          
        Vector3 center = new Vector3(0, 0, 0);

        for (int R = 1; R < mapRows; R++)
        {
            for (int Q = 1; Q < mapColumns; Q++)              
            {
                Hex h = new Hex(Q, R);

                GameObject hx_go = (GameObject) Instantiate(hexPrefab, h.Position(), Quaternion.identity, this.transform);
               
                hx_go.name = "Row_" + R + "_Column_" + Q;
                //hx_go.GetComponent<Hex>().R = R;
                //hx_go.GetComponent<Hex>().Q = Q;

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
