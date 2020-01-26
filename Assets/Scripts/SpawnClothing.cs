using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClothing : MonoBehaviour
{
    public GameObject[] objectPrefabArr;
    public Vector3 center;
    public Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<3; i++)
        {
            SpawnObject();
            Global.counter++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.counter < 3)
        {
            SpawnObject();  
            Global.counter++;
        } 
    }

    public void SpawnObject()
    {
        GameObject objectPrefab = getObjectPrefab();
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2) ,0 ,Random.Range(0, size.z/2));

        // check that objects do not spawn in the same location
        GameObject[] list = GameObject.FindGameObjectsWithTag("clothing");
        bool duplicate;
        do{
            duplicate = false;
              for(int i=0; i<list.Length; i++)
             {
                GameObject obj = list[i];

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

   GameObject getObjectPrefab()
   {
      return objectPrefabArr[Random.Range(0,2)];
   }
}
