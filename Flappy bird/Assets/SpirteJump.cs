using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpirteJump : MonoBehaviour
{
    Rigidbody2D bird;
    Vector2 up = new Vector2(0,1);
    public float thrust = 8;
    public GameObject[] MenuForCheck;

    public int score;
     AudioSource jumpAudio;
     AudioSource scoreAudio;
    
    void Start()
    {
        jumpAudio = transform.GetChild(0).gameObject.GetComponent<AudioSource>();
        scoreAudio = transform.GetChild(1).gameObject.GetComponent<AudioSource>();

        bird = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")) && (!MenuForCheck[0].activeSelf && !MenuForCheck[1].activeSelf && !MenuForCheck[2].activeSelf))
        {
            //bird.AddForce(up * thrust, ForceMode2D.Impulse);
            bird.velocity = Vector2.up * thrust;
            jumpAudio.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        scoreAudio.Play();
        score++;
    }
}
