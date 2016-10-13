using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
  public static GameManager control = null;
  AudioSource backgroundMusic;
  public AudioClip[] musicbg;
  public bool muted = false;
  public bool Trophy01;
  public bool Trophy02;
  public bool Trophy03;
  public bool Trophy04;
  public bool Trophy05;
  public bool Trophy06;

  private int i;

	void Awake ()
  {
    if (control == null)
    {
      control = this;
    } else if (control != this) {
      Destroy(gameObject);
    }
    DontDestroyOnLoad(gameObject);
    backgroundMusic = GetComponent <AudioSource> ();
	}

  void Start ()
  {
    i = UnityEngine.Random.Range(0,musicbg.Length);
    StartCoroutine("Playlist");
  }

  public void MuteMusic ()
  {
    if(!muted)
    {
      muted = true;
      backgroundMusic.Pause();
    } else {
      muted = false;
    }
	}

  IEnumerator Playlist()
  {
    while(true)
    {
      yield return new WaitForSeconds(1.0f);
      if((!backgroundMusic.isPlaying) && (!muted))
      {
        if(i != (musicbg.Length -1)) {
          i++;
          backgroundMusic.clip = musicbg[i];
          backgroundMusic.Play();
        } else {
          i=0;
          backgroundMusic.clip= musicbg[i];
          backgroundMusic.Play();
        }
      }
    }
  }

}
