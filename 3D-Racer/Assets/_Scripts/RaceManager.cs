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

  public float laps = 3f;
  public float currentLap = 1f;
  public int checkpointsCleared;
  public int checkpointsPerLap;
  public float time;
  public bool racing = false;

	void Awake ()
  {
    control = this;
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
    yield return new WaitForSeconds (1);
    startTimer.SetActive(false);
    racing = true;
    StartCoroutine("RaceTimer");
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
