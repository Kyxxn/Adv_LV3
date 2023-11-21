using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;

    void Update()
    {
        if (score < 0)
        {
            score = 0;
        }
        GetComponent<TextMeshProUGUI>().text = "x " + score.ToString();
    }
}
