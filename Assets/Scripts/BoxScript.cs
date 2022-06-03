using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    const float speed = 5.0f;

    public GameObject boxUpHalved;

    void Update()
    {
        //transform.Translate(-speed * Time.deltaTime, 0, 0);
        transform.position += Time.deltaTime * -transform.right * 2;
    }

    public void Break()
    {
        Instantiate(boxUpHalved, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
