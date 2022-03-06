using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    private Menu _menu;

    private void Start()
    {
        _menu = FindObjectOfType<Menu>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_menu.IsGameStarted)
        {
            var player = other.GetComponent<PlayerHealth>();

            if (player)
            {
                var newHitAudio = Instantiate(_hitAudio).GetComponent<AudioSource>();
                newHitAudio.pitch = Random.Range(0.7f, 1f);
                newHitAudio.Play();
                player.Die();
            }
            var wall = other.GetComponent<Wall>();
            if (wall)
            {
                Destroy(gameObject);
            }

            Destroy(gameObject, 5f);
        }
    }

}
