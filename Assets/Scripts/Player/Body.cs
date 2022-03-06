using UnityEngine;

public class Body : MonoBehaviour
{
    private PlayerMover _playerMover;
    private float _angleZ;
    private float _angleX;

    private void Start()
    {
        _playerMover = FindObjectOfType<PlayerMover>();
    }
    private void Update()
    {
        _angleZ = Mathf.Lerp(_angleZ, -_playerMover.Horizontal * 30, Time.deltaTime * 5f);
        transform.localEulerAngles = Vector3.right * _angleZ;
        
        _angleX = Mathf.Lerp(_angleX, -_playerMover.Vertical * 10, Time.deltaTime * 5f);
        transform.localEulerAngles = Vector3.forward * _angleZ;

    }
}
