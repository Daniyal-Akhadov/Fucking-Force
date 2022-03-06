using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private GameObject _hitAudio;

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerHealth>();
        if (player)
        {
            var newHitAudio = Instantiate(_hitAudio).GetComponent<AudioSource>();
            newHitAudio.volume = 0.07f;
            newHitAudio.Play();
            player.Die();
            Destroy(newHitAudio.gameObject, 2f);
        }
    }


}
