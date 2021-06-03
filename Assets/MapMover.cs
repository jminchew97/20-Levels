using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMover : MonoBehaviour
{

    [SerializeField]float left = -.5f;
    [SerializeField] float right = .5f;
    [SerializeField] float yUp = .5f;
    [SerializeField] float yDown = -.5f;
    [SerializeField] float forward = .5f;
    [SerializeField] float back = -.5f;
    Vector3 mousePosition;
    Vector3 playerMove;
    // Start is called before the first frame update
    void Start()
    {
        mousePosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
