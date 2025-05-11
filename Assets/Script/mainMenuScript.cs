using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenuScript : MonoBehaviour
{

    [SerializeField] private Button start;
    [SerializeField] private Button info;
    [SerializeField] private Button exit;
    [SerializeField] private Button infoBack;
    [SerializeField] private GameObject startCanvas;
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject infoScreen;
    [SerializeField] private GameObject menuScreen;

    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(() => {
            startCanvas.SetActive(true);
            menuCanvas.SetActive(false);
        });

        info.onClick.AddListener(() => {
            infoScreen.SetActive(true);
            menuScreen.SetActive(false);
        });

        infoBack.onClick.AddListener(() => {
            infoScreen.SetActive(false);
            menuScreen.SetActive(true);
        });

        exit.onClick.AddListener(() => {
            Application.Quit();
        });
    }
}
