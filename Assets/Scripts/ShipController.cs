using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float moveY = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        transform.position += new Vector3(moveX * _speed, moveY * _speed, 0);
    }
}
