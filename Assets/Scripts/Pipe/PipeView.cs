using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Events;

public class PipeView : MonoBehaviour
{

    public UnityAction<Transform> OnCreatePipe;
    // Start is called before the first frame update
    void Start()
    {
        OnCreatePipe?.Invoke(transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x <= -3.5f)
        {
            Destroy(gameObject); 
        }

        transform.Translate(-3.2f * Time.deltaTime, 0, 0);

    }
    


}
