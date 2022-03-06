using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject _winCanvas;
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerMover>();
        if (player)
        {
            Cursor.visible = true;
            _winCanvas.SetActive(true);
        }
    }
}
