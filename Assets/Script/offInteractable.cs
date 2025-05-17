using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class offInteractable : MonoBehaviour
{
    public Button btn;

    void Start()
    {
        btn.onClick.AddListener(()=>{
            btn.interactable = false;
        });
    }
}
