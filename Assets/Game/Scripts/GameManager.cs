using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = true;
    private UIManager _uiManager;
    private SpawnManager _spawnManager;
    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        IsGameOver();
    }
    void IsGameOver()
    {
        if (gameOver == true) { 
        if (Input.GetKeyDown(KeyCode.Space)) { 
                    gameOver = false;
                    _uiManager.HideTitleScreen();
                    Time.timeScale = 1f;
                
            }
        }
        if (gameOver == false)
        {
            if (_spawnManager != null)
            {
                _spawnManager.coinHurdleSpawning();
                _spawnManager.powerupSpawn();
            }
        }
    }
}
