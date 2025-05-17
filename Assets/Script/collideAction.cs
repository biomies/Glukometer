using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collideAction : MonoBehaviour
{

    public Button setActiveButton;
    public Button setActiveFalseButton;
    public GameObject setActiveFalseGO;
    public Image hand;
    public Sprite stateNextHand;

    public AudioSource aus;
    public AudioClip ac;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("target"))
        {
            setActiveButton.interactable = true;
            setActiveFalseButton.interactable = false;
            setActiveFalseGO.SetActive(false);
            hand.sprite = stateNextHand;
            aus.clip = ac;
            aus.Play();
        }
    }
}
