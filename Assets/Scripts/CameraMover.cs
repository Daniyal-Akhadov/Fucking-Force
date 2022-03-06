using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;
    private Rigidbody _rigidbody;
    private PlayerMover _playerMover;
    private Menu _menu;

    public float Speed
    {
        get => _speed;
    }
    private void Start()
    {
        _menu = FindObjectOfType<Menu>();
        _playerMover = FindObjectOfType<PlayerMover>();
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (_menu.IsGameStarted)
        {
            _rigidbody.velocity = new Vector3(0, 0, _speed) * _playerMover.Boost;
        }
    }
}
