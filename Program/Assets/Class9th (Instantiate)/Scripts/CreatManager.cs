using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatManager : MonoBehaviour
{
    [SerializeField] GameObject food;
    [SerializeField] GameObject clone;
    [SerializeField] float time;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time >= 5.0f)
        {
            clone = Instantiate(food);

            time = 0.0f;
        }
    }
}
