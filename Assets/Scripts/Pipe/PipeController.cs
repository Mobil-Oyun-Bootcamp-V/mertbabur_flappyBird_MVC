using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController
{
    private PipeModel _model;
    private PipeView _view;

    public PipeController(PipeView view)
    {
        _view = view;
        _view.OnCreatePipe = CreatePipe;
        
        _model = new PipeModel();
    }

    private void CreatePipe(Transform pipeTransform)
    {
        float random = Random.Range(6f, 8.36f);
        pipeTransform.position = new Vector3(3.43f, random, pipeTransform.position.z);
    }
}
