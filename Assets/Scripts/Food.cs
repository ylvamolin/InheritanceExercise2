using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usable
{
    public float saturation;
    public bool isYummy;

    public override void Use()
    {
        base.Use();
    }

    public override string CannotUse()
    {
        return "Dem är slut pucko.";
    }

    public override string UseText()
    {
        return "Du har ätit " + itemName + "." + uses + " kvar.";
    }

    public override string NoUsesRemainingText()
    {
        return "Kan inte använda " + itemName + ", dem är slut.";
    }

    public string YummyToString()
    {
        if (isYummy)
            return "det smakar gott.";
        else
            return "det smakar för jävligt.";
    }

    //lägger till mer text till det som printas i Item scriptet
    public override string ToString()
    {
        return base.ToString() + itemName + ": mättnad = " + saturation + " och " + YummyToString();
    }

}
