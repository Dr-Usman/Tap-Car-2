using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTouch : MonoBehaviour
{
    private UIManager _uiManager;
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)){
                if (_gameManager.gameOver == false)
                {
                    _uiManager.ShowPauseScreen();
                }   
                    }
                }
            }
