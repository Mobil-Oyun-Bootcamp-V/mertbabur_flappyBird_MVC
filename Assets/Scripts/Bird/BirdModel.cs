using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdModel
{
    private float _jumpSpeed = 70f;
    private float _fallSpeed = 1f;
    
    private int _score = 0;
    private int _scoreAmount = 1;

    public float JumpSpeed
    {
        get => _jumpSpeed;
        set => _jumpSpeed = value;
    }

    public float FallSpeed
    {
        get => _fallSpeed;
        set => _fallSpeed = value;
    }
    
    public int Score
    {
        get => _score;
        set => _score = value;
    }

    public int ScoreAmount
    {
        get => _scoreAmount;
        set => _scoreAmount = value;
    }

}
