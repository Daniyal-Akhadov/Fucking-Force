using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _bangEffect;
    public void Die()
    {
        Instantiate(_bangEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
