using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform _leftFireTrans;
    [SerializeField] private Transform _rightFireTrans;
    [SerializeField] private GameObject _bulletPref;
    private float _lastShootTime;
    private float _shootSpeed = 1f;

    private void Start()
    {
        _lastShootTime = Time.time;
    }

    private void Update()
    {
        if (Time.time > _lastShootTime + _shootSpeed)
        {
            Fire();
            _lastShootTime = Time.time;
        }

    }

    private void Fire()
    {
        GameObject rightBullet = Instantiate(_bulletPref, _rightFireTrans.position, Quaternion.identity);
        GameObject leftBullet = Instantiate(_bulletPref, _leftFireTrans.position, Quaternion.identity);
    }
}

