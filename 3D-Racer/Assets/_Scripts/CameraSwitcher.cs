using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour
{

  [SerializeField] private GameObject[] cameras = new GameObject[4];

	void Update ()
  {
    if (Input.GetKeyDown("1") && cameras[0] != null)
    {
      switchCameras(0);
    }
    else if (Input.GetKeyDown("2") && cameras[1] != null)
    {
      switchCameras(1);
    }
    else if (Input.GetKeyDown("3") && cameras[2] != null)
    {
      switchCameras(2);
    }
	}

  private void switchCameras(int keyNum)
  {
    for (int i = 0; i < cameras.Length; i++)
    {
      if (cameras[i] != null && keyNum != i) {
        // turn camera off
        cameras[i].SetActive(false);
      } else {
        // turn camera on
        cameras[i].SetActive(true);
      }
    }
  }
}
