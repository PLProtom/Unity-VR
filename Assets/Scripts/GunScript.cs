using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    //STEROWANIE MYSZKA. Dopoki nie mamy dostepu do VR
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            var pos = Input.mousePosition;
            pos.z = 2;
            pos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = pos;
        }
    }
}
