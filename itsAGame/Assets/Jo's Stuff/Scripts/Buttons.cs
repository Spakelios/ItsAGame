using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    private UnlevelledGiuseppe giuseppePriority;


    public void fightButton()
    {
        giuseppePriority.Fight();
    }

    public void healButton()
    {
        giuseppePriority.Heal();
    }
}
