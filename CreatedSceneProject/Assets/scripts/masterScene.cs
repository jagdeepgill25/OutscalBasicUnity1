using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class masterScene : MonoBehaviour
{
    public Button button;
    public Button button2;
    public Button button3;
 
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
        button2.onClick.AddListener(OnButtonClick);
        button3.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        var currentButton = EventSystem.current.currentSelectedGameObject;

        var length = currentButton.name.Length;
        var lastChar = currentButton.name[length-1];
       //Debug.Log("button clicked,", btnName.name);
        Debug.Log("Clicked on : " + length);
        Debug.Log("Clicked lst on : " +lastChar);
        SceneManager.LoadScene("scene" + lastChar);
    }




}
