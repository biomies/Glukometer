using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pressButtonShowObject : MonoBehaviour
{

    [SerializeField] GameObject objectShow;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(()=>{
            objectShow.SetActive(true);
        });
    }
}
