using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackLaser : MonoBehaviour
{
    [SerializeField] private GameObject _hitAudio;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = _hitAudio.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        var newHitAudio = Instantiate(_hitAudio).GetComponent<AudioSource>();
        var player = other.GetComponent<PlayerHealth>();
        var enemy = other.GetComponent<Enemy>();
        if (player)
        {
            newHitAudio.volume = 0.07f;
            newHitAudio.Play();
            player.Die();
            Destroy(newHitAudio.gameObject, 2f);
        }

        if (enemy)
        {
            newHitAudio.Play();
            newHitAudio.volume = Random.Range(0.002f, 0.035f);
            newHitAudio.Play();
            enemy.Die();
            Destroy(newHitAudio.gameObject, 2f);

        }

    }
}
