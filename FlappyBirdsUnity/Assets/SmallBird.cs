using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBird : MonoBehaviour
   
    
{
    public float upForce = 200f;
    Rigidbody2D FlappyBird;
    public AudioSource buttonPressed;
    // Start is called before the first frame update
    void Start()
    {
        FlappyBird = GetComponent<Rigidbody2D>();
        buttonPressed = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")&&GameManager.isActive)
        {
            //FlappyBird.AddForce(new Vector2(0, 100f));
            FlappyBird.AddForce(Vector2.up * upForce);
            buttonPressed.Play();
        }
    }
}
