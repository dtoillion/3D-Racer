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
      LevelButtons[4].interactable = true;
    }
    if(GameManager.control.Trophy05)
    {
      Trophies[4].SetActive(true);
      LevelButtons[5].interactable = true;
    }
    if(GameManager.control.Trophy06)
    {
      Trophies[5].SetActive(true);
      LevelButtons[6].interactable = true;
    }
    if(GameManager.control.Trophy07)
    {
      Trophies[6].SetActive(true);
      LevelButtons[7].interactable = true;
    }
    if(GameManager.control.Trophy08)
    {
      Trophies[7].SetActive(true);
      LevelButtons[8].interactable = true;
    }
    if(GameManager.control.Trophy09)
    {
      Trophies[8].SetActive(true);
      LevelButtons[9].interactable = true;
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
