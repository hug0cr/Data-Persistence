using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public static Action PlayerExitApplication;
    public void ChangePlayerName(string playerName)
    {
        GameManager.Instance.playerName = playerName;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitApplication()
    {
        PlayerExitApplication();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }
}
