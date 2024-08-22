using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatManager : MonoBehaviour
{
    [SerializeField] GameObject food;
    [SerializeField] GameObject clone;
    [SerializeField] float time = 5.0f;

    WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);

    private void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        while(true)
        { 

            Debug.Log("Start Coroutine");

            yield return waitForSeconds;

        }
    }
}
