using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    const float speed = 5.0f;
    public enum BoxType { Up, Down,Left, Right, Any, Shoot};
    public BoxType boxType;

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

                if (direction.x > 0) { if (boxType == BoxType.Left || boxType == BoxType.Any) { BoxHit(); } } //left
                else { if (boxType == BoxType.Right || boxType == BoxType.Any) { BoxHit(); } } //right

            }
            else
            {

                if (direction.y > 0) { if (boxType == BoxType.Down || boxType == BoxType.Any) { BoxHit(); } } //down
                else { if (boxType == BoxType.Up || boxType == BoxType.Any) { BoxHit(); } } //up

            }
        }
    }

    void BoxHit()
    {
        Destroy(gameObject);
    }
}
