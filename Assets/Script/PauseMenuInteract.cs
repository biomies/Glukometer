using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuInteract : MonoBehaviour
{
    public Button lanjutkan;
    public Button exit;

    public GameObject pause;

    void Start()
    {
        lanjutkan.onClick.AddListener(()=>{
            pause.SetActive(false);
        });

        exit.onClick.AddListener(()=> {
            Application.Quit();
        });
    }
}
