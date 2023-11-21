using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class ReactCall : MonoBehaviour
{
    public Button yourButton; // 에디터에서 할당할 버튼 변수
    
    [DllImport("__Internal")] 
    private static extern void reactScoreUp(int curScore);
    void Start()
    {
        yourButton.onClick.AddListener(TaskOnClick); // 버튼 클릭 리스너 추가
    }

    void TaskOnClick()
    {
        // C# 및 유니티에서 사용되는 전처리 지시문
        // 조건부 컴파일을 위하며 참일 때만 동작
        // 유니티 WebGL 플랫폼이 맞고, 유니티 에디터 내에서 실행되지 않았을 때(배포된 경우 동작)
#if UNITY_WEBGL == true && UNITY_EDITOR == false
        reactScoreUp(Score.score);
#endif
        Debug.Log("Error");
    }
}
