using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy)
        {
            _hitAudio.pitch = Random.Range(0.3f, 0.6f);
            _hitAudio.Play();
            enemy.Die();
        }

        if (other.GetComponent<Wall>())
        {
            Destroy(gameObject);
        }


        Destroy(gameObject, 0.8f);
    }
}
