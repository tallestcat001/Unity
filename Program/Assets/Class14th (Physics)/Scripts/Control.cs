using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;

    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidBody;

    // Start is called before the first frame update
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
