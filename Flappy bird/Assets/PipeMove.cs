using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    float pipeVelocity = 0.3f;
    Vector2 forward = new Vector2(-1,0);
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = forward * pipeVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(forward * pipeVelocity * Time.deltaTime);
    }
}
