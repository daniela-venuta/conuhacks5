using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClothing : MonoBehaviour
{
    public GameObject objectPrefab;
    public Vector3 center;
    public Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("clothing").Length < 3)
        {
            SpawnObject();  
        } 
    }

    public void SpawnObject()
    {
        Vector3 pos = center + new Vector3(Random.Range(0, size.x/2) ,0 ,Random.Range(0, size.y/2));

        // check that objects do not spawn in the same location
        GameObject[] list = GameObject.FindGameObjectsWithTag("clothing");
        bool duplicate;
        do{
            duplicate = false;
             for(int i=0; i<list.Length; i++)
            {
                GameObject obj = list[i];
                Vector3 objSize = obj.GetComponent<Collider>().bounds.size;

                if(obj.transform.position.x == pos.x || obj.transform.position.z == pos.z)
                {
                    duplicate = true;
                    pos = center + new Vector3(Random.Range(-size.x/2, size.x/2) ,0 ,Random.Range(0, size.z/2));
                }
             }
        }while(duplicate);
       
           
        Instantiate(objectPrefab, pos, Quaternion.identity);
        objectPrefab.tag = "clothing";
    }
}
