using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   [SerializeField] private BackLaser _backLaser;
    private bool _isGameStarted;

    public bool IsGameStarted
    {
        get => _isGameStarted;
    }
    public void StartLevel()
    {
        Debug.Log("Start level");
        Time.timeScale = 1f;
        _isGameStarted = true;
        _backLaser.gameObject.SetActive(true);
        Cursor.visible = false;
    }

    public void Restart()
    {      
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
