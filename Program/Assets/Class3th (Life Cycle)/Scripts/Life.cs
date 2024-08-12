using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    void Awake()
    {
        // Awake�Լ��� ���� ������Ʈ�� �����Ǿ�����, �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ���� ȣ��Ǵ� �̺�Ʈ �Լ�.

        Debug.Log("Awake");
    }

    void OnEnable()
    {
        // OnEnable�Լ��� ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� ��, ȣ��Ǵ� �̺�Ʈ �Լ�.

        Debug.Log("OnEnable");
    }

    void Start()
    {
        // Start�Լ��� ���� ������Ʈ�� �����Ǿ�����, �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ�� �����϶��� ȣ����� �ʴ� �̺�Ʈ �Լ�.

        Debug.Log("Start");
    }

    void PixedUpdata()
    {
        // TimeStep�̶�� ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ�.

        Debug.Log("Pixed Updata");
    }

    void Update()
    {
        // Update�Լ��� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�.

        Debug.Log("Update");
    }

    void LateUpdate()
    {
        // Update�Լ��� ���� �Ŀ� ȣ��Ǵ� �̺�Ʈ �Լ�.

        Debug.Log("LateUpdate");
    }

    void OnDisable()
    {
        // ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ�����, ȣ��Ǵ� �Լ�.

        Debug.Log("OnDisable");
    }

    void OnDestroy()
    {
        // ���� ������Ʈ�� �ı��Ǿ�����, ȣ��Ǵ� �̺�Ʈ �Լ�.

        Debug.Log("OnDestroy");
    }
}
