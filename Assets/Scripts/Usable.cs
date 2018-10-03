using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item
{
    public int uses;
    public int maxUses;

    void Start()
    {
        uses = maxUses;
    }

    //när du trycker på objektet
    public void OnMouseUpAsButton()
    {
        if (uses >= 1)
        {
            print(UseText());
            Use();
        }
        else if (uses <= -1)
        {
            print(CannotUse());
        }
        else
        {
            print(NoUsesRemainingText());
            Use();
        }

    }

    public virtual void Use()
    {
        uses--;
    }

    public virtual string CannotUse()
    {
        uses = maxUses;
        return "Dem är slut pucko.";
    }

    public virtual string UseText()
    {
        return "Du har använt " + itemName + ". Du har " + uses + " kvar.";               
    }

    public virtual string NoUsesRemainingText()
    {
        return "Du kan inte använda " + itemName + " för att du är död!";
    }

    //lägger till mer text till den som printas i Item scriptet
    public override string ToString()
    {
        return base.ToString() + " Kan användas " + maxUses + " gånger." + uses + " kvar. ";
    }

}
