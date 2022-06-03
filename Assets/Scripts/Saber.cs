using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{

	public LayerMask layer;
    public LayerMask wrongLayer;

	private Vector3 previousPos;

    PointsScript ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("Points").GetComponent<PointsScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position, transform.right *1.4f, Color.red);
        RaycastHit hit;
	if(Physics.Raycast(transform.position,transform.right,out hit,1.4f,layer))
	{
		if(Vector3.Angle(transform.position-previousPos,hit.transform.up)>130)
		{
                //Destroy(hit.transform.gameObject);
                ps.points += 1 * (ps.combo + 1);
                ps.combo++;
                if (ps.hp < 100)
                {
                    ps.hp += 1;
                }
                hit.transform.gameObject.GetComponent<BoxScript>().Break();
		} else {
                ps.combo = 0;
                ps.hp -= 5;
                hit.transform.gameObject.GetComponent<BoxScript>().Break();
        }
	}
    if (Physics.Raycast(transform.position, transform.right, out hit, 1.4f, wrongLayer))
    {
            ps.combo = 0;
            ps.hp -= 5;
            hit.transform.gameObject.GetComponent<BoxScript>().Break();
    }
    previousPos = transform.position;
    }
}
