using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceManager : MonoBehaviour
{
  public static RaceManager control;

  public GameObject endRace;
  public Text endRaceText;
  public GameObject startTimer;
  public Text startTimerText;
  public GameObject[] checkpoints;
  public Rigidbody raceCar1;
  public Rigidbody raceCar2;
  public Rigidbody raceCar3;
  public Rigidbody raceCar4;

  public float laps = 3f;
  public float currentLap = 1f;
  public int checkpointsCleared;
  public int checkpointsPerLap;
  public float time;
  public bool racing = false;

	void Awake ()
  {
    control = this;
    raceCar1.isKinematic = true;
    raceCar2.isKinematic = true;
    raceCar3.isKinematic = true;
    raceCar4.isKinematic = true;
	}

  void Start ()
  {
    StartCoroutine (CountDown());
  }

  public void AdvanceCheckpoints ()
  {
    if(checkpointsCleared != checkpointsPerLap)
    {
      checkpoints[checkpointsCleared].SetActive(true);
    } else {
      checkpoints[0].SetActive(true);
    }

  }

  public void ResetLaps ()
  {
    // reset checkpoints cleared
    if((checkpointsCleared == checkpointsPerLap) && (currentLap != laps))
    {
      currentLap++;
      checkpointsCleared = 0;
    }
    // end race when laps is reached and all checkpoints cleared
    if((checkpointsCleared == checkpointsPerLap) && (currentLap == laps))
    {

      racing = false;
      endRace.SetActive(true);
      endRaceText.text = RaceManager.control.time.ToString("00:00.00");
      raceCar1.isKinematic = true;
      raceCar2.isKinematic = true;
      raceCar3.isKinematic = true;
      raceCar4.isKinematic = true;
      Scene scene = SceneManager.GetActiveScene();
      if(scene.buildIndex == 1)
        GameManager.control.Trophy01 = true;
      if(scene.buildIndex == 2)
        GameManager.control.Trophy02 = true;
      if(scene.buildIndex == 3)
        GameManager.control.Trophy03 = true;
      if(scene.buildIndex == 4)
        GameManager.control.Trophy04 = true;
      if(scene.buildIndex == 5)
        GameManager.control.Trophy05 = true;
      if(scene.buildIndex == 6)
        GameManager.control.Trophy06 = true;
      if(scene.buildIndex == 7)
        GameManager.control.Trophy07 = true;
      if(scene.buildIndex == 8)
        GameManager.control.Trophy08 = true;
      if(scene.buildIndex == 9)
        GameManager.control.Trophy09 = true;
    }
  }

  IEnumerator CountDown ()
  {
    startTimer.SetActive(true);
    startTimerText.text = "3";
    yield return new WaitForSeconds (1);
    startTimerText.text = "2";
    yield return new WaitForSeconds (1);
    startTimerText.text = "1";
    yield return new WaitForSeconds (1);
    startTimerText.text = "GO!";
    racing = true;
    raceCar1.isKinematic = false;
    raceCar2.isKinematic = false;
    raceCar3.isKinematic = false;
    raceCar4.isKinematic = false;
    StartCoroutine("RaceTimer");
    yield return new WaitForSeconds (1);
    startTimer.SetActive(false);
  }

  IEnumerator RaceTimer ()
  {
    while(racing)
    {
      for (int i = 0; i < 1; i++)
      {
        time += Time.deltaTime;
        yield return new WaitForSeconds (0.01f);
      }
    }
  }


}
