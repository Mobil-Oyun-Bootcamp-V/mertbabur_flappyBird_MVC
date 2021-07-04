using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController
{
    private BirdModel _model;
    private BirdView _view;
    
    public BirdController(BirdView view)
    {
        _view = view;
        _view.OnFlyBird = FlyBird;
        _view.OnFallBird = FallBird;
        _view.OnAddScore = AddScore;

        _model = new BirdModel();
        
        _view.OnSetScore = SetScore;

    }

    private void FlyBird(Rigidbody2D birdRB, Transform birdTransform)
    {
        birdRB.velocity = Vector2.zero;
        birdRB.velocity = Vector2.up * _model.JumpSpeed * Time.deltaTime;

        birdTransform.eulerAngles = new Vector3(birdTransform.eulerAngles.x, birdTransform.eulerAngles.y, 60);
    }

    private void FallBird(Transform birdTransform)
    {
        birdTransform.eulerAngles -= new Vector3(birdTransform.eulerAngles.x, birdTransform.eulerAngles.y, _model.FallSpeed);
    }
    
    private void AddScore(Text scoreText)
    {
        _model.Score += _model.ScoreAmount;
        scoreText.text = _model.Score.ToString();
    }
    
    private void SetScore(Text scoreText)
    {
        scoreText.text = _model.Score.ToString();
    }
    
}
