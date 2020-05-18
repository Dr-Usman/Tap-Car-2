using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _coinPrefab;
    [SerializeField]
    private GameObject _redPrefab;
    [SerializeField]
    private GameObject _bluePrefab;
    [SerializeField]
    private GameObject[] powerups;
    [SerializeField]
    private float _spawnRate = 0.1f;
    private float _nextSpawn = 0.0f;
    private int _whatToSpawn;

    private float _wait1 = 0.0f;
    private float _wait2 = 18.0f;

    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void coinHurdleSpawning()
    {
            if (Time.time > _nextSpawn)
            {
                _whatToSpawn = Random.Range(0, 25);

                switch (_whatToSpawn)
                {
                    case 1:
                        Instantiate(_coinPrefab, new Vector3(-2.22f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(0.82f, 6.45f, 0), Quaternion.identity);
                        break;

                    case 2:
                        Instantiate(_coinPrefab, new Vector3(-2.22f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(2.22f, 6.45f, 0), Quaternion.identity);
                        break;

                    case 3:
                        Instantiate(_coinPrefab, new Vector3(-0.82f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(0.82f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(_coinPrefab, new Vector3(-0.82f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(2.22f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(_coinPrefab, new Vector3(-2.22f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_bluePrefab, new Vector3(0.82f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(_coinPrefab, new Vector3(-2.22f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_bluePrefab, new Vector3(2.22f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(_coinPrefab, new Vector3(-0.82f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_bluePrefab, new Vector3(0.82f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(_coinPrefab, new Vector3(-0.82f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_bluePrefab, new Vector3(2.22f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(_coinPrefab, new Vector3(0.82f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(-2.22f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(_coinPrefab, new Vector3(0.82f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(-0.82f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(_coinPrefab, new Vector3(2.22f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(-2.22f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(_coinPrefab, new Vector3(2.22f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(-0.82f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(_bluePrefab, new Vector3(0.82f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(-0.82f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(_bluePrefab, new Vector3(0.82f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(-2.22f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(_bluePrefab, new Vector3(2.22f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(-0.82f, 6.45f, 0), Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(_bluePrefab, new Vector3(2.22f, 5.6f, 0), Quaternion.identity);
                        Instantiate(_coinPrefab, new Vector3(-2.22f, 6.45f, 0), Quaternion.identity);
                    break;
                case 17:
                    Instantiate(_bluePrefab, new Vector3(2.22f, 5.6f, 0), Quaternion.identity);
                    Instantiate(_redPrefab, new Vector3(-0.82f, 6.45f, 0), Quaternion.identity);
                    break;
                case 18:
                    Instantiate(_bluePrefab, new Vector3(2.22f, 5.6f, 0), Quaternion.identity);
                    Instantiate(_redPrefab, new Vector3(-2.22f, 6.45f, 0), Quaternion.identity);
                    break;
                case 19:
                    Instantiate(_bluePrefab, new Vector3(0.82f, 5.6f, 0), Quaternion.identity);
                    Instantiate(_redPrefab, new Vector3(-0.82f, 6.45f, 0), Quaternion.identity);
                    break;
                case 20:
                    Instantiate(_bluePrefab, new Vector3(0.82f, 5.6f, 0), Quaternion.identity);
                    Instantiate(_redPrefab, new Vector3(-2.22f, 6.45f, 0), Quaternion.identity);
                    break;
                case 21:
                    Instantiate(_bluePrefab, new Vector3(2.22f, 6.45f, 0), Quaternion.identity);
                    Instantiate(_redPrefab, new Vector3(-0.82f, 5.6f, 0), Quaternion.identity);
                    break;
                case 22:
                    Instantiate(_bluePrefab, new Vector3(2.22f, 6.45f, 0), Quaternion.identity);
                    Instantiate(_redPrefab, new Vector3(-2.22f, 5.6f, 0), Quaternion.identity);
                    break;
                case 23:
                    Instantiate(_bluePrefab, new Vector3(0.82f, 6.45f, 0), Quaternion.identity);
                    Instantiate(_redPrefab, new Vector3(-0.82f, 5.6f, 0), Quaternion.identity);
                    break;
                case 24:
                    Instantiate(_bluePrefab, new Vector3(0.82f, 6.45f, 0), Quaternion.identity);
                    Instantiate(_redPrefab, new Vector3(-2.22f, 5.6f, 0), Quaternion.identity);
                    break;
            }
            _nextSpawn = Time.time + _spawnRate;
        }
        }
    public void  powerupSpawn()
    {
        int randomPowerup = Random.Range(0, 2);
        if (Time.time > _wait1)
        {
            int randomx = Random.Range(0, 4);
            switch (randomx)
            {
                case 0:
                    Instantiate(powerups[randomPowerup], new Vector3(-2.22f, 7.7f, 0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(powerups[randomPowerup], new Vector3(-0.82f, 7.7f, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(powerups[randomPowerup], new Vector3(0.82f, 7.7f, 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(powerups[randomPowerup], new Vector3(2.22f, 7.7f, 0), Quaternion.identity);
                    break;
            }
            _wait1 = Time.time + _wait2;
        }
    }    
    }
