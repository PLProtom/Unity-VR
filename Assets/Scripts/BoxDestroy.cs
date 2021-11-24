using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    IEnumerator waiter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Granica")
        {
            StartCoroutine(waiter());
        }
    }
}
