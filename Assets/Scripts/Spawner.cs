using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject orange;
    public GameObject orangeAny;
    public GameObject purple;
    public GameObject purpleAny;

    public GameObject startCube;
    public GameObject[] spawner;
    public int isStarted;

    public Quaternion up = new Quaternion(0, -0.707106829f, 0, 0.707106829f);
    public Quaternion down = new Quaternion(0.707106829f, 0, 0.707106829f, 0);
    public Quaternion left = new Quaternion(0.5f, -0.5f, 0.5f, 0.5f);
    public Quaternion right = new Quaternion(-0.5f, -0.5f, -0.5f, 0.5f);

    void Start()
    {
        
    }

    void Update()
    {
        if(isStarted == 0)
        {
            start startScript = startCube.GetComponent<start>();
            isStarted = startScript.isStarted;
        }

        if (isStarted == 1)
        {
            isStarted = 2;
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        while(true)
        {
            Instantiate(purple, spawner[0].transform.position, up);
            yield return new WaitForSeconds(1);
            Instantiate(purple, spawner[3].transform.position, left);
            yield return new WaitForSeconds(1);
            Instantiate(purple, spawner[4].transform.position, down);
            yield return new WaitForSeconds(1);
            Instantiate(purple, spawner[7].transform.position, left);
            yield return new WaitForSeconds(1);
            Instantiate(orange, spawner[1].transform.position, up);
            Instantiate(orange, spawner[5].transform.position, up);
            yield return new WaitForSeconds(1);
            Instantiate(orange, spawner[2].transform.position, right);
            Instantiate(orange, spawner[6].transform.position, right);
            yield return new WaitForSeconds(1);
            Instantiate(orange, spawner[1].transform.position, down);
            yield return new WaitForSeconds(1);
        }
    }
}
