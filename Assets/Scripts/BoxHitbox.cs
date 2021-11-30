using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHitbox : MonoBehaviour
{
    [SerializeField] private GameObject hitbox1;
    [SerializeField] private GameObject hitbox2;
    [SerializeField] private bool hitbox1Activated = false;
    [SerializeField] private bool hitbox2Activated = false;

    IEnumerator waiter()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            hitbox1Activated = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == hitbox2)
        {
            hitbox2Activated = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other == hitbox1)
        {
            hitbox1Activated = true;
            StartCoroutine(waiter());
        }

        if (other == hitbox2)
        {
            hitbox2Activated = false;
        }
    }
    private void Update()
    {
        if (hitbox1Activated && hitbox2Activated)
        {
            Destroy(gameObject);
        }
    }
}
