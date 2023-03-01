using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneToMainMenu : MonoBehaviour
{
    public void SwitchToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
