using UnityEngine;

public class EnemyShooter : Shooter
{
    private bool _isShooted;

    private void Update()
    {
        if (_isShooted)
            CreateBullet();
    }

    private void FixedUpdate()
    {
        if (_isShooted)
            Shoot();
    }

    private void OnTriggerStay(Collider other)
    {
        var player = other.GetComponent<PlayerMover>();
        if (player)
        {
            _isShooted = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var player = other.GetComponent<PlayerMover>();
        if (player)
        {
            _isShooted = false;
        }
    }
}
