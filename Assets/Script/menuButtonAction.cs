using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuButtonAction : MonoBehaviour
{
    public Button btn;
    public GameObject go;

    void Start()
    {
        btn.onClick.AddListener(()=> {
            if (go.activeSelf)
            {
                go.SetActive(false);
            } else {
                go.SetActive(true);
            }
        });
    }
}
