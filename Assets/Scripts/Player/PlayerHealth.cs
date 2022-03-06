using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject _bangEffect;
    [SerializeField] private GameObject _loseCanvas;
    private bool _isLived = true;
    public bool IsLived 
    {
        get => _isLived;
    }

    public void Die()
    {
        Instantiate(_bangEffect, transform.position, Quaternion.identity);
        Destroy(gameObject, 2);
        _loseCanvas.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
    }
}
