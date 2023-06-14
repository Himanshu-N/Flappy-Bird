using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    public GameObject Bird;
    public GameObject Ready123;
    public GameObject Pipes;
    Animator anima;
    void Start()
    {
        anima = Ready123.GetComponent<Animator>();
    }
    void Update()
    {
        if (Ready123.activeInHierarchy == true){
            AnimationClip clip = anima.GetCurrentAnimatorClipInfo(0)[0].clip;
            if (clip != null && clip.name == "ready 321")
            {
                Invoke("DisableReady", clip.length);
            }
        }   
    }
    

    void DisableReady()
    {
        
    }
}
