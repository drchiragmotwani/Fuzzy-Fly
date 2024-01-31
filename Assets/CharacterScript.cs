using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public Rigidbody2D characterRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool characterIsAlive = true;
    public AudioSource characterSound;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("LogicManager").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && characterIsAlive)
        {
            characterRigidbody.velocity = Vector2.up * flapStrength;
            characterSound.Play();
        }

        if (transform.position.y > 15 || transform.position.y < -15)
        {
            logic.GameOver();
            characterIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        characterIsAlive = false;
    }
}
