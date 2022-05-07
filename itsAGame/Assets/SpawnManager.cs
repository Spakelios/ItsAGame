using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject RoundOne, RoundTwo, RoundThree, RoundFour;

  private void Start()
  {
    StartCoroutine("Round1");
  }

  IEnumerator Round1()
  {
    RoundOne.SetActive(true);
    yield return new WaitForSeconds(10f);
    StartCoroutine("Round2");
  }

  IEnumerator Round2()
  {
    RoundOne.SetActive(false);
    RoundTwo.SetActive(true);
    yield return new WaitForSeconds(10f);
    StartCoroutine("Round3");
  }

  IEnumerator Round3()
  { 
    RoundTwo.SetActive(false);
    RoundThree.SetActive(true);
    yield return new WaitForSeconds(10f);
    Round4();
  }
  
  private void Round4()
  { 
    RoundThree.SetActive(false);
    RoundFour.SetActive(true);
  }
  
}


