using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] private float _boost = 3;
    [SerializeField] private Vector3 _speedConstant;
    [SerializeField] private TrailRenderer _trail;
    [SerializeField] private TrailRenderer _boostTrail;

    private Menu _menu;
    private CameraMover _cameraMover;
    private Rigidbody _rigidbody;
    private float _horizontal;
    private float _vertical;

    public float Horizontal
    {
        get => _horizontal;
    }
    public float Vertical
    {
        get => _vertical;
    }
    public float Boost
    {
        get => _boost;
    }
    private void Start()
    {
        _cameraMover = FindObjectOfType<CameraMover>();
        _speedConstant = new Vector3(0, 0, _cameraMover.Speed);
        _rigidbody = GetComponent<Rigidbody>();
        _menu = FindObjectOfType<Menu>();
    }

    private void Update()
    {
        if (_menu.IsGameStarted)
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.LeftShift))
            {
                _boost = 3;
                _trail.enabled = false;
                _boostTrail.enabled = true;
            }
            else
            {
                _boost = 1;
                _trail.enabled = true;
                _boostTrail.enabled = false;
            }
        }
    }

    private void FixedUpdate()
    {
        if (_menu.IsGameStarted)
        {
            Vector3 direction = new Vector3(_horizontal, 0f, _vertical) * _speed * Time.deltaTime;
            _rigidbody.velocity = direction + _speedConstant * Boost;
        }
    }
}
