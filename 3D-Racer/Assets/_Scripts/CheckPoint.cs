using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour
{

  void OnTriggerEnter(Collider trig)
  {
    if(trig.gameObject.tag == "PlayerColliders")
    {
      RaceManager.control.checkpointsCleared++;
      RaceManager.control.ResetLaps();
      RaceManager.control.AdvanceCheckpoints();
      gameObject.SetActive(false);
    }
  }

}
