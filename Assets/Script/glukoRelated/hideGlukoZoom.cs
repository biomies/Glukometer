using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideGlukoZoom : MonoBehaviour
{
    public Button btnNext;
    public GameObject hideGO;
    public Button nextButton;

    void Start()
    {
        btnNext.onClick.AddListener(()=> {
            hideGO.SetActive(false);
            nextButton.interactable = true;
        });
    }
}
