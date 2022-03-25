using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PointsScript : MonoBehaviour
{
    public int combo = 0;
    public int points = 0;
    public int hp = 100;

    public TMP_Text comboText;
    public TMP_Text pointsText;
    public TMP_Text hpText;

    void Start()
    {
        
    }

    void Update()
    {
        if (hp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        comboText.text = combo + " X";
        pointsText.text = points + "";
        hpText.text = hp + "%";
    }
}
