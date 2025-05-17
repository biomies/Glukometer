using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keTesSelanjutnya : MonoBehaviour
{
    public Button btn;
    public GameObject currTes;
    public GameObject nextTes;

    void Start()
    {
        btn.onClick.AddListener(()=>{
            currTes.SetActive(false);
            nextTes.SetActive(true);
        });
    }
}
