using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 1;
    private int rotateDir;

    private void Start()
    {
        rotateDir = Random.Range(-2, 2);
        if(rotateDir==0)
        {
            rotateDir = 1;
        }
    }

    void FixedUpdate()
    {
        gameObject.transform.Rotate(new Vector3(0,0,rotateDir*rotationSpeed), Space.Self);
    }
}
