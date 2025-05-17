using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideTime : MonoBehaviour
{
    public Button btn;
    public GameObject timeGO;

    void Start()
    {
        btn.onClick.AddListener(()=>{
            timeGO.SetActive(false);
        });
    }
}
