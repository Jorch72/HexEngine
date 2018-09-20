using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HexMap: MonoBehaviour
{
    public GameObject hexPrefab;

    public int mapRows;
    public int mapColumns;

    public Material[] HexMaterials;

    void GenerateMap()
    {
        for (int Q = 0; Q < mapColumns; Q++)
        {
            for (int R = 0; R < mapRows; R++)
            {
                Hex h = new Hex(Q, R);

                Vector3 pos = h.PositionFromCamera(Camera.main.transform.position, mapRows, mapColumns);
                Debug.Log(pos);
                GameObject hx_go = (GameObject)Instantiate(
                    hexPrefab,
                    pos,
                    //h.Position(),
                    Quaternion.identity,
                    this.transform);
                hx_go.GetComponent<HexComponent>().Hex = h;
                hx_go.GetComponent<HexComponent>().HexMap = this;

                hx_go.name = "Row_" + R + "_Column_" + Q;
                MeshRenderer mr = hx_go.GetComponentInChildren<MeshRenderer>();
                mr.material = HexMaterials[Random.Range(0, HexMaterials.Length)];

            }
            //StaticBatchingUtility.Combine(this.gameObject);
        }
        
    }
    void Start()
    {
        GenerateMap();
    }
}
