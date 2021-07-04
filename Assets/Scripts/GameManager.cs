using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BirdView birdView;
    private BirdController _birdController;

    // Start is called before the first frame update
    void Start()
    {
        _birdController = new BirdController(birdView);
        
    }
    
}
