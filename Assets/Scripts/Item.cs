using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string itemName;
    public float itemValue;
    public float itemWeight;
    public Text itemInfoText;

    public void Update()
    {

    }

    private float GetPricePerWeight()
    {
        return itemValue / itemWeight;
    }

    public override string ToString()
    {
        return itemName + " kostar " + GetPricePerWeight() + "kr/kg. ";
    }

    //printar texten från ToString() när man håller musen ovanför ett objekt.
    public void OnMouseEnter()
    {
        print(ToString());
        itemInfoText.text = ToString();
    }

    public void OnMouseExit()
    {
        itemInfoText.text = " ";
    }
}
