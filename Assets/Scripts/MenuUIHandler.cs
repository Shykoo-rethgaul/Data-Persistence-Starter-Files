using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
 

    public InputField input;
    static string username;
    // Use a button UI that calls this function that saves the input text into Player Prefs.
    public void OnButtonClick()
    {
        PlayerPrefs.SetString("SomeSaveName", input.text);
        username = input.text;
        Debug.Log(username + " has been set as username.");
    }

    // If the "SomeSaveName" exists when this script is called on start, it will put the text into the inputfield.
    private void Start()
    {
        if (PlayerPrefs.HasKey("SomeSaveName"))
        {
            input.text = PlayerPrefs.GetString("SomeSaveName");
            
        }
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();       
#endif
        Application.Quit();

    }
    public void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }
}
