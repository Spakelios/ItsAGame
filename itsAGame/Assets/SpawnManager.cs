using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject RoundOne, RoundTwo, RoundThree, RoundFour, textOne, TextThree, TextTwo, TextFour;

  private void Start()
  {
    StartCoroutine("Round1");
  }

  IEnumerator Round1()
  {
    RoundOne.SetActive(true);
    textOne.SetActive(true);
    yield return new WaitForSeconds(10f);
    StartCoroutine("Round2");
  }

  IEnumerator Round2()
  {
    RoundTwo.SetActive(true);
    textOne.SetActive(false);
    TextTwo.SetActive(true);
    yield return new WaitForSeconds(8f);
    StartCoroutine("Round3");
  }

  IEnumerator Round3()
  {
    TextTwo.SetActive(false);
    TextThree.SetActive(true);
    RoundThree.SetActive(true);
    yield return new WaitForSeconds(7f);
    Round4();
  }
  
  private void Round4()
  {
    TextThree.SetActive(false);
    TextFour.SetActive(true);
    RoundFour.SetActive(true);
  }
  
}


