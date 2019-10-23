using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PointsAdd : MonoBehaviour
{
    public Material mEnter;
    public Material mExit;
    Renderer myRender;

    public bool figuraGanadora;
    public float totalTime;
    float timeCurrent;
    bool isEnable;
    int spawnIndex = 0;
    
    void Awake()
    {
        myRender = GetComponent<Renderer>();
        myRender.enabled = true;
        
    }

    public void OnPointerEnter()
    {
        myRender.sharedMaterial = mEnter;
        isEnable = true;

    }

    public void OnPointerExit()
    {
        myRender.sharedMaterial = mExit;
        isEnable = false;
        timeCurrent = 0;
    }

    private void Update() {
        ProgressTimer();
    }

    private void ProgressTimer()
    {
        if (isEnable)
        {
            timeCurrent += Time.deltaTime;
            if (figuraGanadora)
            {                
                if (timeCurrent >= totalTime)
                {
                    //ganaste
                    Debug.Log("Ganaste");
                    Scene CurrentScene = SceneManager.GetActiveScene();
                    if(CurrentScene.name == "Nivel1")
                    { SceneManager.LoadScene("Nivel2"); }
                    else if(CurrentScene.name == "Nivel2")
                    { SceneManager.LoadScene("Nivel3"); }
                    else if (CurrentScene.name == "Nivel3")
                    { SceneManager.LoadScene("Nivel4"); }
                        
                }
            }            
        }
    }

    private void Destruction()
    {
        
    }
}
