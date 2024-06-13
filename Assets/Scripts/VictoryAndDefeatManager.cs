using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryAndDefeatManager : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

}