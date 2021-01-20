using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class minorScenes : MonoBehaviour
{
    public Button backButton;
    public string scene;

    private void Start()
    {
        backButton.onClick.AddListener(onButtonClick);
    }
    private void onButtonClick()
    {
        Debug.Log("back button clicked");
        SceneManager.LoadScene(scene);

    }
}
