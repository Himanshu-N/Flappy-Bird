using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreContorl : MonoBehaviour
{
    public GameObject spirte;



    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = spirte.GetComponent<SpirteJump>().score.ToString();
    }

}
