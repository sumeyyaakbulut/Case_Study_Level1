using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomolive : MonoBehaviour
{
    public GameObject FoodPrefab;
    public int prefabscount;
    public Vector3 center;
    public Vector3 size;
    


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < prefabscount; i++)
        {
            Spawnfood();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
  
        /*if (Input.GetKey(KeyCode.Q))
        {
           Spawnfood();
        }*/
    }
    public void Spawnfood()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2,size.x/2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(FoodPrefab, pos, Quaternion.identity);
    }

     void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center,size);
    }
}
