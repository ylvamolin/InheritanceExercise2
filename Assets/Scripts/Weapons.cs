using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : Usable
{
    public bool itHurts;

    public override void Use()
    {
        base.Use();
    }

    public override string CannotUse()
    {
        return "Du är död, hörru.";
    }

    public override string UseText()
    {
        return "Du högg dig själv med " + itemName + "." + uses + " hugg kvar.";
    }

    public override string NoUsesRemainingText()
    {
        return "Kan inte använda " + itemName + ", du är död.";
    }

    public string HurtsToString()
    {
            return " gör ont.";
    }

    //lägger till mer text till den som printas i Item scriptet
    public override string ToString()
    {
        return base.ToString() + itemName + HurtsToString();
    }
}
