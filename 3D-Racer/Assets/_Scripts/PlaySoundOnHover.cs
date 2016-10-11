using UnityEngine;
using System.Collections;

public class PlaySoundOnHover : MonoBehaviour
{
  public AudioSource hoverAudio;

  void Awake ()
  {
    hoverAudio = GetComponent <AudioSource> ();
  }

	void OnMouseEnter()
  {
    Debug.Log("moused over");
    if(!hoverAudio.isPlaying)
      hoverAudio.Play();
	}

}
