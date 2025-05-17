using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeSceneButton : MonoBehaviour
{
    public Button myButton; // Drag button dari Inspector
    public string sceneName; // Nama scene tujuan

    void Start()
    {
        myButton.onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
