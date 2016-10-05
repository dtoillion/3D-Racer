using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
  public GameObject loadingImage;

  public void LoadScene(int level)
  {
    loadingImage.SetActive(true);
    SceneManager.LoadScene(level);
  }

  public void ExitGame()
  {
    Application.Quit();
  }

  public void MuteMusic ()
  {
    GameManager.control.MuteMusic();
  }

}
