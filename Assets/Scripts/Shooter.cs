using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private float _speed = 10;
    [SerializeField] private float _timer = 0.4f;
    [SerializeField] private GameObject _shotAudio;
    [SerializeField] private float _maxPitchSound;
    [SerializeField] private float _minPitchSound;
    private Bullet newBulletPrefab;
    private bool _isShoot;
    private float _tempTimer;
    private Menu _menu;

    private void Start()
    {
        _tempTimer = _timer;
        _menu = FindObjectOfType<Menu>();
    }
    private void Update()
    {
        if (_menu.IsGameStarted)
        {
            if (_tempTimer <= 0 && Input.GetKey(KeyCode.Space))
            {
                newBulletPrefab = Instantiate(_bulletPrefab, transform.position, Quaternion.identity, transform);
                _isShoot = true;
                _tempTimer = _timer;
            }
            _tempTimer -= Time.deltaTime;
        }
    }


    protected void CreateBullet()
    {
        if (_tempTimer <= 0)
        {
            newBulletPrefab = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            _isShoot = true;
            _tempTimer = _timer;
        }
        _tempTimer -= Time.deltaTime;
    }

    protected void Shoot()
    {
        if (_isShoot)
        {
            AudioSource newShotSound = Instantiate(_shotAudio).GetComponent<AudioSource>();
            newShotSound.pitch = Random.Range(_minPitchSound, _maxPitchSound);
            newShotSound.Play();
            Destroy(newShotSound, 2);
            newBulletPrefab.GetComponent<Rigidbody>().velocity = Vector3.forward * _speed;
            _isShoot = false;
        }
    }

}
