using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dodgy : MonoBehaviour
{
    [SerializeField]float timeCount = 1f;
    public bool invincible;
    float currentTime;
    float x = 0f;
    float z = 0f;
    [SerializeField] Transform mapTransform;
    [SerializeField]float moveSpeed = 5f;
    float softener = 10f;
    Rigidbody myRigid;
    [SerializeField]float threshold = 10f;
    Vector3 mousePosition;
    Vector3 moveVec = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    GameObject spawnPoint;
    public int lastLevel = 1;
    public int currentLevel = 1;
    int health;
    public bool canMove;
    public bool gotYconstraint = false;
    
    Scene currentScene;
    // Singleton pattern to keep player

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        if (currentScene.buildIndex == 0)
        {
            PlayerPrefs.DeleteAll();
            health = 10;
            PlayerPrefs.SetInt("Health", health);
        }
        else
        {
            health = PlayerPrefs.GetInt("Health");
        }
        myRigid = GetComponent<Rigidbody>();
        
        mousePosition = Input.mousePosition;
        canMove = false;
        

        
        


    }

    // Update is called once per frame
    void Update()
    {
        MousePosition();
        MovePlayer();

        PlayerPrefs.SetInt("Health", health);


        // debug
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(1);
        }
        

    }

    
    private float SeeIfNumNegative(float number)
    {
        if(number < 0)
        {
            return -1f;
        }
        else if (number > 0)
        {
            return 1f ;
        }
        else
        {
            return 0f;
        }
    }
    private void MovePlayer()
    {
        if (canMove)
        {
            myRigid.AddForce(mousePosition.x / (Screen.width / 2),
                0,
                mousePosition.y / (Screen.height / 2), 
                ForceMode.Force);
            
        }
    }

    
    private void MousePosition()
    {
        //Debug.Log(Time.time);
        mousePosition = Input.mousePosition;
        mousePosition.x -= (Screen.width) / 2;
        mousePosition.y -= (Screen.height) / 2;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground" && invincible == false) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.tag == "Ground" && !gotYconstraint)
        {
            gotYconstraint = true;
            myRigid.constraints = RigidbodyConstraints.FreezePositionY;

        }
    }
    
}
