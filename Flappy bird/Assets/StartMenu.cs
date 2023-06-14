using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Startmenu;

    // Update is called once per frame
    void Start()
    {
        Time.timeScale = 0;
    }

    public void StartIt()
    {
        Time.timeScale = 1;
        Startmenu.SetActive(false);
        
    }
}
