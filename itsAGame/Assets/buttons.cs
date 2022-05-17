using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public UnlevelledGiuseppe giuseppePriority;
    
    public void cringe()
    {
        SceneManager.LoadScene("new");
    }
    
        public void fightButton()
        {
            giuseppePriority.Fight();
        }
    
        public void healButton()
        {
            giuseppePriority.Heal();
        }
}
