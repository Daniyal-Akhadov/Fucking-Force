using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource[] _backgroundSounds;
    public static MusicController Instance;
    private int _index;

    private void Start()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _backgroundSounds[_index].Play();
        }

    }
    private void Update()
    {



        if (!_backgroundSounds[_index].isPlaying)
        {
            _index++;
            _index %= _backgroundSounds.Length;
            _backgroundSounds[_index].Play();   
        }

    }


    public void Pause()
    {
        _backgroundSounds[_index].Pause();
    }


    public void UnPause()
    {
        _backgroundSounds[_index].UnPause();
    }

}
