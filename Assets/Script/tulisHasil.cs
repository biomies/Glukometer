using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tulisHasil : MonoBehaviour
{
    [Header("Random Number Generators")]
    public randNumberGluko rng1;
    public randNumberGluko rng2;
    public randNumberGluko rng3;
    
    [Header("String Output")]
    public String tes1;
    public String tes2;
    public String tes3;

    [Header("Tes 1")]
    public TextMeshProUGUI tes1text1;
    public TextMeshProUGUI tes2text1;
    public TextMeshProUGUI tes3text1;

    [Header("Tes 2")]
    public TextMeshProUGUI tes1text2;
    public TextMeshProUGUI tes2text2;
    public TextMeshProUGUI tes3text2;

    [Header("Tes 3")]
    public TextMeshProUGUI tes1text3;
    public TextMeshProUGUI tes2text3;
    public TextMeshProUGUI tes3text3;

    

    void Update()
    {
        tes1 = rng1.randomNumber.ToString();
        tes2 = rng2.randomNumber.ToString();
        tes3 = rng3.randomNumber.ToString();

        tes1text1.text = tes1;
        tes2text1.text = tes2;
        tes3text1.text = tes3;

        tes1text2.text = tes1;
        tes2text2.text = tes2;
        tes3text2.text = tes3;

        tes1text3.text = tes1;
        tes2text3.text = tes2;
        tes3text3.text = tes3;
    }
}
