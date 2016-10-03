using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
  public bool muted = false;
  public AudioClip[] musicbg;
  AudioSource backgroundMusic;

  private int i;


	void Awake ()
  {
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
