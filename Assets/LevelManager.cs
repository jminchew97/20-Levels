using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject[] Levels;
    [SerializeField]Dodgy player;
    
    int levelThreshold = 2;
    int currentLevel;
    int lastLevel;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = player.GetComponent<DodgyLevelControl>().currentLevel;

        //Variable to keep track if level changes
        lastLevel = currentLevel;

        DisableAllLevelsUponGameStart();
    }

    private void DisableAllLevelsUponGameStart()
    {
        foreach(GameObject level in Levels)
        {
            level.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentLevel = player.GetComponent<DodgyLevelControl>().currentLevel;
        IfLevelChangesUpdateLevelsThatAreEnabled();
        EnableFirstLevelsAtStart();
    }

    private void EnableFirstLevelsAtStart()
    {
        if (currentLevel < levelThreshold)
        {
            for (int i = 0; i < Levels.Length; i++)
            {
                if (i < levelThreshold *3)
                {
                    Levels[i].SetActive(true);
                }
                
            }
        }
    }

    private void IfLevelChangesUpdateLevelsThatAreEnabled()
    {
        //check if level and last level are different
        if (lastLevel != currentLevel)
        {
            
            //update last level
            lastLevel = currentLevel;

            //disable previoous levels that arent in threshold
            if (currentLevel  > levelThreshold  )
            {
                    // Set levels inactive that meet the threshold
                    Levels[currentLevel - 1 - levelThreshold].SetActive(false);
                    //Enable level forward that meet level threshhold
                    if (Levels[currentLevel - 1 + levelThreshold].activeSelf == false)
                    {
                        Levels[currentLevel - 1 + levelThreshold].SetActive(true);
                    }
            }
            
        }
    }
}
