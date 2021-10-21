using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float _bullletSpeed = 0.1f;
    void Update()
    {
        transform.position += new Vector3(0, _bullletSpeed, 0);
    }
}
