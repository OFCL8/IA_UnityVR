using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PointsAdd : MonoBehaviour
{
    public Material mEnter;
    public Material mExit;
    Renderer myRender;

    public GameObject[] figura;

    public Transform[] spawnPoints;

    public float totalTime;
    float timeCurrent;
    bool isEnable;
    int spawnIndex = 0;
    
    void Awake()
    {
        myRender = GetComponent<Renderer>();
        myRender.enabled = true;
        myRender.sharedMaterial = mExit;
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
            if (timeCurrent >= totalTime)
            {
                isEnable = false;
                //Debug.Log("TIME!");
                //int n = Random.Range(0, figura.Length-1);
                //Debug.Log("" + n);
                Destruction();
            }
        }
    }

    private void Destruction()
    {
        spawnIndex = Random.Range(0, spawnPoints.Length);

        int n = Random.Range(0, figura.Length);
        Debug.Log("" + n);
        Instantiate(figura[n],spawnPoints[spawnIndex].position,spawnPoints[spawnIndex].rotation);

        Destroy(this.gameObject);
    }
}
