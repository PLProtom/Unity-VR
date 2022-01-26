using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsScript : MonoBehaviour
{
    public int combo = 0;
    public int points = 0;

    public TMP_Text comboText;
    public TMP_Text pointsText;

    void Start()
    {
        
    }

    void Update()
    {
        comboText.text = combo + " X";
        pointsText.text = points + "";
    }
}
