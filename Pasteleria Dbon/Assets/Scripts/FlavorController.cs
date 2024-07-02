using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FlavorController : MonoBehaviour
{
    private TMP_Dropdown colorOptions;
    public Image pastel;

    public Sprite[] flavorBase;
 
    void Start()
    {
       colorOptions = GetComponent<TMP_Dropdown>();
       pastel = GameObject.Find("Pastel").GetComponent<Image>();
    }
    
    public void ChangeFlavor()
    {
        switch (colorOptions.value)
        {
            case 0:
                pastel.sprite = flavorBase[0];
                break;
            case 1:
                pastel.sprite = flavorBase[1];
                break;
            case 2:
                pastel.sprite = flavorBase[2];
                break;
        }
    }


}
