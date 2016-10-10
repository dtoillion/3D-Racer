using UnityEngine;
using System.Collections;

public class Fence : MonoBehaviour
{
  public GameObject FencePart1;
  public GameObject FencePart2;
	public GameObject FencePart3;

  void OnCollisionEnter(Collision trig)
  {
    if((trig.gameObject.tag == "Player") || (trig.gameObject.tag == "AICar"))
    {
      FencePart1.SetActive(false);
      FencePart2.SetActive(true);
      FencePart3.SetActive(true);
    }
  }

}
