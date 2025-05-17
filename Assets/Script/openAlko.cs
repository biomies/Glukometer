using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openAlko : MonoBehaviour
{
    [SerializeField] Button alko;
    [SerializeField] Image alkoImage;
    [SerializeField] Sprite alkoClosed;
    [SerializeField] Sprite alkoOpened;

    void Start()
    {
        alko.onClick.AddListener(()=> {
            alkoImage.sprite = alkoOpened;
            alko.enabled = false;
        });
    }
}
