using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] private float xRotation;
    [SerializeField] private float yRotation;
    [SerializeField] private float zRotation;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(xRotation, yRotation, zRotation) * Time.deltaTime);
    }
}
