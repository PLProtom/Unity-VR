using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    const float speed = 5.0f;

    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
