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
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;
    public GameObject spawner6;

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
            Instantiate(cubeUp, spawner5.transform.position, transform.rotation);
            yield return new WaitForSeconds(3);
            Instantiate(cubeDown, spawner2.transform.position, transform.rotation);
            yield return new WaitForSeconds(3);
            Instantiate(cubeAny, spawner1.transform.position, transform.rotation);
            yield return new WaitForSeconds(3);
            Instantiate(cubeDown, spawner3.transform.position, transform.rotation);
            Instantiate(cubeDown, spawner6.transform.position, transform.rotation);
            yield return new WaitForSeconds(3);
            Instantiate(cubeAny, spawner4.transform.position, transform.rotation);
            Instantiate(cubeAny, spawner5.transform.position, transform.rotation);
            Instantiate(cubeAny, spawner6.transform.position, transform.rotation);
            yield return new WaitForSeconds(3);
        }
    }
}
