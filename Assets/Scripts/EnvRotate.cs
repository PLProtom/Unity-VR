using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvRotate : MonoBehaviour
{
    [SerializeField] private GameObject obiekt;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        float fixedSpeed = speed * Time.deltaTime;
        obiekt.transform.Rotate(0f, 0f, fixedSpeed, Space.Self);
    }
}
