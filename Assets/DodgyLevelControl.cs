using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DodgyLevelControl : MonoBehaviour
{
    public int currentLevel = 1;
    public bool exitedBlockingWall = false;
    public bool touchingNewWorldTrigger = false;
    [SerializeField]TextMeshProUGUI levelText;
    private string levelName;
    string levelNumber;
    char[] stringChars;
    int levelNumberInt;
    bool gotFirstlevel = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level:" + currentLevel;



    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground" && gotFirstlevel == false)
        {
            gotFirstlevel = true;
            Debug.Log("New LEvel");
            levelName = "";
            levelName = collision.gameObject.transform.parent.name;
            Debug.Log(levelName);
            stringChars = levelName.ToCharArray();

            for (int i = 0; i < levelName.Length; i++)
            {
                if (Char.IsDigit(stringChars[i]))
                {
                    levelNumber += stringChars[i];
                }

            }
            levelNumberInt = int.Parse(levelNumber);
            currentLevel = levelNumberInt;
            
        }
        
    }
}
