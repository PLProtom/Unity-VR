using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    PointsScript ps;

    private void Start()
    {
        ps = GameObject.Find("Points").GetComponent<PointsScript>();
    }

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
            ps.combo = 0;
            ps.hp -= 5;
            StartCoroutine(waiter());
        }
    }
}
