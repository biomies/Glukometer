using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class glukoAction : MonoBehaviour
{
    public GameObject showGluko;
    public GameObject setActiveFalseGO;
    public Button setActiveFalseButton;
    public AudioSource aus;
    public AudioClip ac;

    void OnTriggerEnter2D(Collider2D other)
    {
        showGluko.SetActive(true);
        setActiveFalseGO.SetActive(false);
        setActiveFalseButton.interactable = false;
        aus.clip = ac;
        aus.Play();
    }
}
