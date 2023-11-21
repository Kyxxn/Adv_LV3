using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGame1 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Game1");
    }
}
