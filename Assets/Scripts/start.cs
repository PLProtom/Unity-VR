using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public int isStarted = 0;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        isStarted = 1;
        gameObject.SetActive(false);
    }
}
