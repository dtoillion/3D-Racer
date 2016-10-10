using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
  public GameObject loadingImage;
  public GameObject[] Trophies;

  void Start ()
  {
    SetupTrophies();
  }

  public void SetupTrophies ()
  {
    if(GameManager.control.Trophy01){ Trophies[0].SetActive(true); }
    if(GameManager.control.Trophy02){ Trophies[1].SetActive(true); }
    if(GameManager.control.Trophy03){ Trophies[2].SetActive(true); }
    if(GameManager.control.Trophy04){ Trophies[3].SetActive(true); }
    if(GameManager.control.Trophy05){ Trophies[4].SetActive(true); }
    if(GameManager.control.Trophy06){ Trophies[5].SetActive(true); }
    if(GameManager.control.Trophy07){ Trophies[6].SetActive(true); }
    if(GameManager.control.Trophy08){ Trophies[7].SetActive(true); }
    if(GameManager.control.Trophy09){ Trophies[8].SetActive(true); }
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
