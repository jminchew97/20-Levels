using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class FallerBoy : MonoBehaviour
{
    public float currentTime = 0f;
    DodgyLevelControl dodgyLevelControl;
    [SerializeField] int currentLevel = 0;
    [SerializeField] float timeTrigger = 5f;

    string levelName;
    string levelNumber;
    char[] stringChars;
    int levelNumberInt;
    // Start is called before the first frame update
    void Start()
    {
        dodgyLevelControl = FindObjectOfType<DodgyLevelControl>();
        levelName = gameObject.transform.parent.gameObject.name;
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

    // Update is called once per frame
    void Update()
    {
        if (currentLevel == dodgyLevelControl.currentLevel )
        {
            currentTime += Time.deltaTime;
            if(currentTime >= timeTrigger)
            {
                GetComponent<Rigidbody>().useGravity = true;
            }
        }
        
       
        
    }
}
