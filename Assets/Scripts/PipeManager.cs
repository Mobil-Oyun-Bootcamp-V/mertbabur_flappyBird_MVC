using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{

    public GameObject pipe;
    
    public PipeView pipeView;
    private PipeController _pipeController; 
    
    // Start is called before the first frame update
    void Start()
    {
        _pipeController = new PipeController(pipeView);

        InvokeRepeating("AddPipe", 0.0f, 2.5f);
    }

    private void AddPipe()
    {
        GameObject newPipe = Instantiate(pipe);
    }
    
}
