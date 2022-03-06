using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : Shooter
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            CreateBullet();
    }

    private void FixedUpdate()
    {
        Shoot();
    }
}
