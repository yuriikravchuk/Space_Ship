using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]private float _speed;
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(0, -_speed);
    }
}
