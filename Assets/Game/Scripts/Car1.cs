using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1 : MonoBehaviour
{
    private Vector3 rPos = new Vector3(-0.82f, -3.22f, 0);
    private Vector3 lPos = new Vector3(-2.22f, -3.22f, 0);
    private GameManager _gameManager;
    int c1 = 0;
    public int collectedCoins1 = 0;
    public int collectedAfterBoost1 = 0;
    public bool antiBoostActive = false;
    public bool scoreBoostActive = false;
    public int count1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-2.22f, -3.22f, 0);
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.A))
                {
                    if (_gameManager.gameOver == false)
                    {
                        Movement();
                    }
                }
        
        if (count1 == 1)
        {
            scoreBoostActive = true;
            StartCoroutine(scoreBoostPowerDownRoutine());
            count1 = 0;
        }
    }
    public void Movement()
    {
        
            if (c1 == 0)
            {
                transform.position = rPos;
                c1++;
            }
            else if (c1 == 1)
            { 
                if (transform.position == rPos)
                {
                    transform.position = lPos;
                    c1--;
                }
            }
        }
    public void antiBoostPowerUp()
    {
        antiBoostActive = true;
        StartCoroutine(antiBoostPowerDownRoutine());
    }
    IEnumerator antiBoostPowerDownRoutine()
    {
        yield return new WaitForSeconds(12.0f);
        antiBoostActive = false;
    }
    IEnumerator scoreBoostPowerDownRoutine()
    {
        yield return new WaitForSeconds(12.0f);
        scoreBoostActive = false;
    }
}
