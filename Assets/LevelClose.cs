using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelIndicator : MonoBehaviour
{
    Dodgy player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider collision)
    {
        player = collision.gameObject.GetComponent<Dodgy>();
        if (player.currentLevel > player.lastLevel && collision.gameObject.name == "Dodgy")
        {
            player.lastLevel++;
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
