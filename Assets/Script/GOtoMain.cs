using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GOtoMain : MonoBehaviour
{
    public void ReplayGame()
    {
        Score.score = 0;
        SceneManager.LoadScene("Main");
    }
}
