using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdView : MonoBehaviour
{

    public UnityAction<Rigidbody2D, Transform> OnFlyBird;
    public UnityAction<Transform> OnFallBird;
    public UnityAction<Text> OnAddScore;
    private Rigidbody2D _birdRB;
    
    public Text scoreText;
    public UnityAction<Text> OnSetScore;
    
    // Start is called before the first frame update
    void Start()
    {
        _birdRB = GetComponent<Rigidbody2D>();
        OnSetScore?.Invoke(scoreText);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnFlyBird?.Invoke(_birdRB, transform);
        }
        else
        {
            OnFallBird?.Invoke(transform);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(0);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnAddScore?.Invoke(scoreText);
    }
}
