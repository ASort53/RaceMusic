using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    Vector3 moveVec;
    float MoveSpeed = 20;

    void Start()
    {
        moveVec = new Vector3(0, 0, -1);
    }

    void Update()
    {
        transform.Translate(moveVec * Time.deltaTime * MoveSpeed);
    }
}