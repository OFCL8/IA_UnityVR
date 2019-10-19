using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucción : MonoBehaviour
{
    public float TiempoDeAparicion = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoDeAparicion -= Time.deltaTime;
        if(TiempoDeAparicion<=0)
        { Destroy(this.gameObject); }
    }
}
