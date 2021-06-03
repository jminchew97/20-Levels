using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGameButtonClick : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AllowPlayerToMove()
    {
        player = GameObject.Find("Dodgy");
        player.GetComponent<Dodgy>().canMove = true;
        GameObject.Find("Button").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
