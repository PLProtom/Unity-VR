using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BottomText : MonoBehaviour
{
    private TextMeshPro textMesh;
    string startText = "Map 1";

    // Start is called before the first frame update
    void Start()
    {
        textMesh = gameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = startText;
    }
}
