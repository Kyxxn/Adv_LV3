using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI timerText; // 타이머를 표시할 TextMeshProUGUI 참조
    void Start()
    {
        timer = 30f;
    }

    // Update is called once per frame
    void Update()
    {        
        if (timer > 0)
        {
            timer -= Time.deltaTime; // 타이머 감소
            timerText.text = "Timer : " + Mathf.RoundToInt(timer).ToString(); // 화면에 표시
        }
        else
        {
            SceneManager.LoadScene("Game_Over"); // 시간이 0이 되면 씬 전환
        }
    }
}
