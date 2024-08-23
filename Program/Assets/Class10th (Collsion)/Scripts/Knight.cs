using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // OnCollisionEnter() : 게임 오브젝트가 물리적인 충돌을 했을 때, 호출되는 이벤트 함수.
        Debug.Log("CollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay() : 게임 오브젝트가 물리적인 출돌을 진행 중일 때, 호출되는 이벤트 함수.
        Debug.Log("CollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnCollisionExit() : 게임 오브젝트가 물리적인 충돌이 끝났을 때, 호출되는 이벤트 함수.
        Debug.Log("CollisionExit");
    }
}
