using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Save1");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
