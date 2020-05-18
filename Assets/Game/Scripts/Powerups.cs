using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6.5f;
    [SerializeField]
    private int powerupID; //0 for anti-boost and 1 for score boost
    [SerializeField]
    private AudioClip _clip;
    private Car1 c1;
    private Car2 c2;
    private UIManager _uiManager;
    // Start is called before the first frame update
    void Start()
    {
        c1 = GameObject.Find("Car1").GetComponent<Car1>();
        c2 = GameObject.Find("Car2").GetComponent<Car2>();
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Car1" || other.tag == "Car2")
        {
            AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position, 1f);
            if (powerupID == 0)
            {
                c1.antiBoostPowerUp();
                c2.antiBoostPowerUp();
            }
            if (powerupID == 1)
            {
                c1.count1++;
                c2.count2++;
            }
            Destroy(this.gameObject);
        }
    }
}
