﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void NewGame()
    {
        PlayerPrefs.SetInt("CurrentState", 0);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int newGameSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(newGameSceneIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
