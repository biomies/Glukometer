using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randNumberGluko : MonoBehaviour
{

    public setGlukoNumber gn;
    public TextMeshProUGUI text;
    public int randomNumber;

    void Start()
    {
        randomNumber = Random.Range(gn.tesmin, gn.tesmax + 1);
        text.text = randomNumber.ToString();
    }
}
