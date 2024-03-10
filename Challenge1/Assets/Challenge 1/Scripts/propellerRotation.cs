using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class propellerRotation : MonoBehaviour
{
    public int speed;
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 360*speed*Time.deltaTime);
    }
}
