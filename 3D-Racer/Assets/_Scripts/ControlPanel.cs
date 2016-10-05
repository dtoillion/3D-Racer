using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ControlPanel : MonoBehaviour
{

  public Text currentLevelText;
  public Text lapText;
  public Text raceTimeText;

  void Start ()
  {
    Scene scene = SceneManager.GetActiveScene();
    currentLevelText.text = scene.name;
  }

  void Update ()
  {
    lapText.text = ("Lap: " + RaceManager.control.currentLap.ToString() + " of " + RaceManager.control.laps.ToString());
    raceTimeText.text = RaceManager.control.time.ToString("00:00.00");
  }

  public void RetryRace ()
  {
    Scene scene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(scene.name);
  }

  public void ReturnToMainMenu ()
  {
    SceneManager.LoadScene(0);
  }

}
