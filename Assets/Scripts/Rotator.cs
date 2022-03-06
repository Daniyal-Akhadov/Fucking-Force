using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _angle;
    void Update()
    {
        transform.Rotate(_angle);
    }
}
