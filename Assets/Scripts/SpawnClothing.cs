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

    void OnDrawGizmosSelected() // what
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center, size);
    }

    public void SpawnObject()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2),0, Random.Range(-size.z/2, size.z/2));
        Instantiate(objectPrefab, pos, Quaternion.identity);
        objectPrefab.tag = "clothing";
    }
}
