using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurdles : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6.5f;
    private GameManager _gameManager;
    private UIManager _uiManager;
    private Car1 c1;
    private Car2 c2;
    GameObject[] clones;
    // Start is called before the first frame update
    void Start()
    {
        c1 = GameObject.Find("Car1").GetComponent<Car1>();
        c2 = GameObject.Find("Car2").GetComponent<Car2>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (transform.position.y < -5.55f)
        {
            Destroy(this.gameObject);
        }
    }
    void Movement()
    {
        if (c1.antiBoostActive == true || c2.antiBoostActive == true)
        {
            transform.Translate(Vector3.down * _speed * 0.5f * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Car1" || other.tag == "Car2")
        {
            Time.timeScale = 0f;
            _uiManager.ShowTitleScreen();
            _gameManager.gameOver = true;
            c1.collectedCoins1 = 0;
            c1.collectedAfterBoost1 = 0;
            c2.collectedAfterBoost2 = 0;
            c2.collectedCoins2 = 0;
            clones = GameObject.FindGameObjectsWithTag("Clone");

            foreach (GameObject c in clones)
            {
                Destroy(c.gameObject);
            }
            Destroy(this.gameObject);
        }
    }
}
