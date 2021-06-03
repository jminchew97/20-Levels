using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingWall : MonoBehaviour
{
    DodgyLevelControl dodgyLevelControl;
    // Start is called before the first frame update
    void Start()
    {
        dodgyLevelControl = FindObjectOfType<DodgyLevelControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            dodgyLevelControl.exitedBlockingWall = true;

            if (dodgyLevelControl.touchingNewWorldTrigger)
            {
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().isTrigger= false;
                dodgyLevelControl.currentLevel++;
            }
        }

        
    }
    
}
