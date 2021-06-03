using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgyPosition : MonoBehaviour
{
    Transform spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = GameObject.Find("SpawnPoint").gameObject.transform;
        Dodgy player = FindObjectOfType<Dodgy>();
        player.transform.position = spawnPosition.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
