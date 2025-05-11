using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class penjelasanScene : MonoBehaviour
{

    [SerializeField] private Button buttonPejelasan1;
    [SerializeField] private Button buttonPejelasan2;
    [SerializeField] private GameObject Pejelasan1;
    [SerializeField] private GameObject Pejelasan2;
    [SerializeField] private GameObject penjelasanScreen;
    [SerializeField] private GameObject welcomePageScreen;



    // Start is called before the first frame update
    void Start()
    {
        buttonPejelasan1.onClick.AddListener(() => {
            Pejelasan2.SetActive(true);
            Pejelasan1.SetActive(false);
        });

        buttonPejelasan2.onClick.AddListener(() => {
            welcomePageScreen.SetActive(true);
            penjelasanScreen.SetActive(false);
        });

    }
}
