using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHalvesDestroy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Destroy(gameObject);
        }
    }
}
