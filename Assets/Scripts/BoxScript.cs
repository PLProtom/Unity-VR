using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    const float speed = 5.0f;
    public enum BoxType { Up, Down,Left, Right, Any, Shoot};
    public BoxType boxType;

    public GameObject boxUpHalved;
    public GameObject boxAnyHalved;

    int hitDir = 0;

    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sword")
        {

            Vector3 direction = transform.position - other.gameObject.transform.position;

            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {

                if (direction.x > 0) { if (boxType == BoxType.Left || boxType == BoxType.Any) { hitDir = 3; BoxHit(); } } //left 3
                else { if (boxType == BoxType.Right || boxType == BoxType.Any) { hitDir = 1; BoxHit(); } } //right 1

            }
            else
            {

                if (direction.y > 0) { if (boxType == BoxType.Down || boxType == BoxType.Any) { hitDir = 2; BoxHit(); } } //down 2
                else { if (boxType == BoxType.Up || boxType == BoxType.Any) { hitDir = 0; BoxHit(); } } //up 0

            }
        }
    }

    void BoxHit()
    {
        Destroy(gameObject);
        if (boxType == BoxType.Up)
        {
            Instantiate(boxUpHalved, transform.position, transform.rotation);
        }
        else if (boxType == BoxType.Down)
        {
            Instantiate(boxUpHalved, transform.position, Quaternion.Euler(new Vector3(hitDir * 90, -90, 0)));
        }
        else if (boxType == BoxType.Left)
        {
            Instantiate(boxUpHalved, transform.position, Quaternion.Euler(new Vector3(hitDir * 90, -90, 0)));
        }
        else if (boxType == BoxType.Right)
        {
            Instantiate(boxUpHalved, transform.position, Quaternion.Euler(new Vector3(hitDir * 90, -90, 0)));
        }
        else if (boxType == BoxType.Any)
        {
            Instantiate(boxAnyHalved, transform.position, Quaternion.Euler(new Vector3(hitDir * 90, -90, 0)));
        }
    }
}
