using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubeUp;
    public GameObject cubeDown;
    public GameObject cubeAny;

    public GameObject spawner1;
    public GameObject spawner2;

    void Start()
    {
        StartCoroutine(waiter());
    }

    void Update()
    {
        
    }

    IEnumerator waiter()
    {
        while(true)
        {
            Instantiate(cubeUp, spawner1.transform.position, transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(cubeDown, transform.position, transform.rotation);
            yield return new WaitForSeconds(5);
            Instantiate(cubeAny, spawner2.transform.position, transform.rotation);
            yield return new WaitForSeconds(5);
        }
    }
}
