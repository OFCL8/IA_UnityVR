using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer Instance;

    float duracionDelNivel =21;
    public int intentosFallidos = 0;
    public float timecurrent;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        duracionDelNivel = 21;
        timecurrent = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
            timecurrent += Time.deltaTime;
            //Debug.Log(duracionDelNivel);
            if (timecurrent >= duracionDelNivel)
            {

                //Perdiste
                intentosFallidos++;
                timecurrent = 0;
                ReloadLevel();
            }
               
    }
    public void ReloadLevel()
    {
        if (intentosFallidos >=3)
        {
            //perdiste
            Destroy(this);
        }
        else
        {
            SceneManager.LoadScene("Nivel1");
        }             
    }
}
