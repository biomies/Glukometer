using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drinkSFX : MonoBehaviour
{
    public Button btn;
    public AudioSource aus;
    public AudioClip ac;

    void Start()
    {
        btn.onClick.AddListener(()=>{
            aus.clip = ac;
            aus.Play();
        });
    }
}
