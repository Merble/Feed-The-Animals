using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    private float speed = 30.0f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(transform.position.z > 35 || transform.position.z < -20)
        {
            Destroy(this);
        }
    }
}