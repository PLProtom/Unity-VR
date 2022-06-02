using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat;
    private float timer;
    private Vector3 spawnRotation;

    public GameObject startCube;
    public int isStarted;

    void Update()
    {
        if(isStarted == 0)
        {
            start startScript = startCube.GetComponent<start>();
            isStarted = startScript.isStarted;
        }

        if (isStarted == 1)
        {
            //isStarted = 2;
            if (timer > beat)
            {
                //cube.transform.Rotate(transform.right, 90 * Random.Range(0, 4));
                   
                GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 7)]);
                cube.transform.localPosition = Vector3.zero;
                int randomRotation = Random.Range(0, 4);

                if (randomRotation == 0)
                {
                    spawnRotation.Set(0, 90, 0);
                }
                else if (randomRotation == 1)
                {
                    spawnRotation.Set(-90, 0, 90);
                }
                else if (randomRotation == 2)
                {
                    spawnRotation.Set(0, -90, 180);
                }
                else if (randomRotation == 3)
                {
                    spawnRotation.Set(90, 0, -90);
                }

                cube.transform.Rotate(spawnRotation);

                timer -= beat;
            }

            timer += Time.deltaTime;
        }
    }
}
