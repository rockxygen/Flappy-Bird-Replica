using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D RB;
    public float velocity = 3f;
    public bool isDead;

    public GameObject deadScene;

    public GameSetup manager;

    void Start()
    {
        //RB = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RB.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name  == "Score")
        {
            manager.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeadArea")
        {
            isDead = true;
            deadScene.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
