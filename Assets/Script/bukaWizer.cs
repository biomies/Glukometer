using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bukaWizer : MonoBehaviour
{
    public Button myButton; // Drag Button dari Inspector
    public string url = "https://app.wizer.me/learn/KBGVX9";

    void Start()
    {
        // Tambahkan listener ke button saat start
        myButton.onClick.AddListener(OpenWebsite);
    }

    void OpenWebsite()
    {
        Application.OpenURL(url);
    }
}
