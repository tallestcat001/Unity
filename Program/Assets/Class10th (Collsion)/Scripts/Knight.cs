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
        // OnCollisionEnter() : ���� ������Ʈ�� �������� �浹�� ���� ��, ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("CollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay() : ���� ������Ʈ�� �������� �⵹�� ���� ���� ��, ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("CollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnCollisionExit() : ���� ������Ʈ�� �������� �浹�� ������ ��, ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("CollisionExit");
    }
}
