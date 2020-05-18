using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject pauseScreen;
    private Image title;
    public Text scoreText;
    public Text timerText;
    private Car1 _c1;
    private Car2 _c2;
    private GameManager _gameManager;
    private int _score = 0;
    private int _score1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _c1 = GameObject.Find("Car1").GetComponent<Car1>();
        _c2 = GameObject.Find("Car2").GetComponent<Car2>();
    }

    public void updateScore()
    {
        if (_c1.scoreBoostActive == true || _c2.scoreBoostActive == true)
        {
            _score1 = _c1.collectedAfterBoost1 + _c2.collectedAfterBoost2 + _score;
            scoreText.text = "" + _score1;
            _c1.collectedCoins1 = 0;
            _c2.collectedCoins2 = 0;
        }
        else
        {
            _score = _c1.collectedCoins1 + _c2.collectedCoins2 + _score1;
            scoreText.text = "" + _score;
            _c1.collectedAfterBoost1 = 0;
            _c2.collectedAfterBoost2 = 0;
        }
    }
    public void ShowTitleScreen()
    {
        titleScreen.SetActive(true);
    }
    public void HideTitleScreen()
    {
        titleScreen.SetActive(false);
        scoreText.text = "0";
        _score = 0;
        _score1 = 0;
    }
    public void ShowPauseScreen()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    public void HidePauseScreen()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
