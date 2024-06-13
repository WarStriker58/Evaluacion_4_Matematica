using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryAndDefeatManager : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1Scene");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

}