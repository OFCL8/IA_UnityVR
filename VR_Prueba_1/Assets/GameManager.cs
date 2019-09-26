using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image imageFade;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Fade", 1);
    }

    void Fade()
    {
        imageFade.CrossFadeAlpha(0, 2, true);
    }
}
