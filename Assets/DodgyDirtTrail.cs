using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgyDirtTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem groundParticles;
    [SerializeField]float currentTime = 0f;
    [SerializeField] float timeTrigger = .05f;
    Rigidbody myRigid;
    [SerializeField]float velocity;
     ParticleSystem.MainModule Main;
    // Start is called before the first frame update
    void Start()
    {
        Main = groundParticles.main;
        myRigid = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime += Time.deltaTime;
        if (currentTime >= timeTrigger)
        {
            velocity = myRigid.velocity.magnitude;
            currentTime = 0;
            //Link size of particles to velocity of dodgy
            Main.startSize = myRigid.velocity.magnitude * .04f;
            //Main.gravityModifier = myRigid.velocity.magnitude * .50f;
            Instantiate(groundParticles,new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z),Quaternion.identity);
            
        }
    }
}
