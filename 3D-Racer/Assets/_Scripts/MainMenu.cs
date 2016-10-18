using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
  public GameObject loadingImage;
  public GameObject[] Trophies;
  public Button[] LevelButtons;

  void Start ()
  {
    SetupTrophies();
  }

  public void SetupTrophies ()
  {
    if(GameManager.control.Trophy01)
    {
      Trophies[0].SetActive(true);
      LevelButtons[1].interactable = true;
    }
    if(GameManager.control.Trophy02)
    {
      Trophies[1].SetActive(true);
      LevelButtons[2].interactable = true;
    }
    if(GameManager.control.Trophy03)
    {
      Trophies[2].SetActive(true);
      LevelButtons[3].interactable = true;
    }
    if(GameManager.control.Trophy04)
    {
      Trophies[3].SetActive(true);
    }
  }

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
