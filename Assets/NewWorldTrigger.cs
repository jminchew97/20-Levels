using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWorldTrigger : MonoBehaviour
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
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            dodgyLevelControl.touchingNewWorldTrigger= true;
            
        }
        
    }
    
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            dodgyLevelControl.touchingNewWorldTrigger = false;
            dodgyLevelControl.exitedBlockingWall = false;
        }
    }
    
}
