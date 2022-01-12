using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BottomText : MonoBehaviour
{
    private TextMeshPro textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
    }

    public void ChangeText(string startText)
    {
        textMesh.text = startText;
    }
}
