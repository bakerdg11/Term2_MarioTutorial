using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnItem : MonoBehaviour
{

    public GameObject[] itemsToSpawn;

    // Start is called before the first frame update
    void Start()
    {


            GameObject collectiblePrefab = itemsToSpawn[Random.Range(0, itemsToSpawn.Length)];
            
            if (collectiblePrefab != null )
            {
                 Instantiate(collectiblePrefab, transform.position, transform.rotation);
            }



    }

    void Update()
    {
        
    }
}
