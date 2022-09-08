using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int countdown = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        countdown= countdown+1;
    }

    void FixedUpdate()
    {
        if (countdown >= 10)
        {
            Debug.Log("Hello world");
            countdown = 0;
        }
    }
}
