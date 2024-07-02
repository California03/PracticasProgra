using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Decorados : MonoBehaviour
{
    private TMP_Dropdown decoradoOptions;
    public Image decorado;

    public Sprite[] decoradosBase;

    void Start()
    {
        decoradoOptions = GetComponent<TMP_Dropdown>();
        decorado = GameObject.Find("Decoracion").GetComponent<Image>();
    }
    public void ChangeDecorado()
    {
        switch (decoradoOptions.value)
        {
            case 0:
                decorado.sprite = decoradosBase[0];
                break;
            case 1:
                decorado.sprite = decoradosBase[1];
                break;
            case 2:
                decorado.sprite = decoradosBase[2];
                break;
        }
    }

}
