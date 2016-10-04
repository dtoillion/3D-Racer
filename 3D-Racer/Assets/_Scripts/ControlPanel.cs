using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ControlPanel : MonoBehaviour
{

  public Text currentLevelText;
  public Text lapText;
  public Text placeText;
  public Text raceTimeText;

  public void Start ()
  {
    Scene scene = SceneManager.GetActiveScene();
    currentLevelText.text = scene.name;
    lapText.text = "Lap: 01 / 02";
    placeText.text = "1st";
    raceTimeText.text = "00:00:00";
  }

  public void ReturnToMainMenu ()
  {
    SceneManager.LoadScene(0);
  }

}
