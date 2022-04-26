using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public TextMeshProUGUI hpCount;
    public int hp;
    void Start()
    {
        hpCount.text = "HP: " + hp;
    }
    
    
}
