using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    void Start()
    {
        transform.position = new Vector3(1, 1, 1);
    }

 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Bar");
        }
    }
}
