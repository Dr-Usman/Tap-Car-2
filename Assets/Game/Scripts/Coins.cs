using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6.5f;
    private UIManager _uiManager;
    private GameManager _gameManager;
    private Car1 c1;
    private Car2 c2;
    [SerializeField]
    private AudioClip _clip;
    GameObject[] clones;
    void Start()
    {
        c1 = GameObject.Find("Car1").GetComponent<Car1>();
        c2 = GameObject.Find("Car2").GetComponent<Car2>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
        if (transform.position.y < -4.5f)
        {
            _uiManager.ShowTitleScreen();
            c1.collectedCoins1 = 0;
            c1.collectedAfterBoost1 = 0;
            c2.collectedCoins2 = 0;
            c2.collectedAfterBoost2 = 0; 
            _gameManager.gameOver = true;
            clones = GameObject.FindGameObjectsWithTag("Clone");

            foreach (GameObject c in clones)
            {
                Destroy(c.gameObject);
            }
            Destroy(this.gameObject);
            Time.timeScale = 0f;
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided with : " + other.name);
        if (other.tag == "Car1")
        {
            Car1 c1 = other.GetComponent<Car1>();
            if (c1 !=null)
            {
                if (c1.scoreBoostActive == true)
                {
                    c1.collectedAfterBoost1 += 2;
                    _uiManager.updateScore();
                    AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position, 1f);
                }
                else
                {
                    c1.collectedCoins1++;
                    AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position, 1f);
                }
            }
            
        }
        if (other.tag == "Car2")
        {
            Car2 c2 = other.GetComponent<Car2>();
            if (c2 != null)
            {
                if (c2.scoreBoostActive == true)
                {
                    c2.collectedAfterBoost2 += 2;
                    _uiManager.updateScore();
                    AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position, 1f);
                }
                else
                {
                    c2.collectedCoins2++;
                    AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position, 1f);
                }
            }
        }
        _uiManager.updateScore();
        Destroy(this.gameObject);
    }
}
