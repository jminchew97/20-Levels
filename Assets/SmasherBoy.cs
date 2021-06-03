using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmasherBoy : MonoBehaviour
{
    public Vector3 originalPosition;
    public Vector3 positionToMoveTo;

    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] float z;
    [SerializeField] float speed;
    public bool moveToPosition = true;
    public bool moveToOriginal = false;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        positionToMoveTo = originalPosition;
        positionToMoveTo.x += x;
        positionToMoveTo.y += y;
        positionToMoveTo.z += z;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveToPosition)
        {
            if(transform.position != positionToMoveTo)
            {
                transform.position = Vector3.MoveTowards(transform.position, positionToMoveTo, speed);
            }
            else
            {
                moveToPosition = false;
                moveToOriginal = true;
            }
        }

        if (moveToOriginal)
        {
            if (transform.position != originalPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, originalPosition, speed);
            }
            else
            {
                moveToPosition = true;
                moveToOriginal = false;
            }
        }
    }
}
