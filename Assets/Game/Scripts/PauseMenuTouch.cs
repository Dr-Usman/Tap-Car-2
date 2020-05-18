using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PauseMenuTouch : MonoBehaviour
{
    private UIManager _uiManager;
    private GameManager _gameManager;
    GameObject[] clones;
    private Car1 c1;
    private Car2 c2;
    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        c1 = GameObject.Find("Car1").GetComponent<Car1>();
        c2 = GameObject.Find("Car2").GetComponent<Car2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            _uiManager.HidePauseScreen();
            _uiManager.ShowTitleScreen();

            clones = GameObject.FindGameObjectsWithTag("Clone");

            foreach (GameObject c in clones)
            {
                Destroy(c.gameObject);
            }
            _gameManager.gameOver = true;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _uiManager.HidePauseScreen();
        }
    }
}
