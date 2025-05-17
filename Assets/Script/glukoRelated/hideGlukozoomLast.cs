using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideGlukozoomLast : MonoBehaviour
{
    public Button btnNext;
    public GameObject hideGO;
    public GameObject nextButton;

    void Start()
    {
        btnNext.onClick.AddListener(()=> {
            hideGO.SetActive(false);
            nextButton.SetActive(true);
        });
    }
}
