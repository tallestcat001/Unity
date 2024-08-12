using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    void Awake()
    {
        // Awake함수는 게임 오브젝트가 생성되었을때, 단 한번만 호출되며, 스크립트가 비활성화된 상태일 때도 호출되는 이벤트 함수.

        Debug.Log("Awake");
    }

    void OnEnable()
    {
        // OnEnable함수는 게임 오브젝트가 활성화되었을 때, 호출되는 이벤트 함수.

        Debug.Log("OnEnable");
    }

    void Start()
    {
        // Start함수는 게임 오브젝트가 생성되었을때, 단 한번만 호출되며, 스크립트가 비활성화된 상태일때는 호출되지 않는 이벤트 함수.

        Debug.Log("Start");
    }

    void PixedUpdata()
    {
        // TimeStep이라는 값에 따라 일정한 간격으로 호출되는 이벤트 함수.

        Debug.Log("Pixed Updata");
    }

    void Update()
    {
        // Update함수는 프레임마다 호출되는 이벤트 함수.

        Debug.Log("Update");
    }

    void LateUpdate()
    {
        // Update함수가 끝난 후에 호출되는 이벤트 함수.

        Debug.Log("LateUpdate");
    }

    void OnDisable()
    {
        // 게임 오브젝트가 비활성화되었을때, 호출되는 함수.

        Debug.Log("OnDisable");
    }

    void OnDestroy()
    {
        // 게임 오브젝트가 파괴되었을때, 호출되는 이벤트 함수.

        Debug.Log("OnDestroy");
    }
}
