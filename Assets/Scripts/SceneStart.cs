using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    [SerializeField]
    private Levels lastExitName;

    private void Start()
    {
        if (PlayerPrefs.GetString("LastExitName") == lastExitName.ToString())
        //if (lastExitName.ToString() == PlayerController.instance.areaTransitionName)
        {
            PlayerController.instance.transform.position = transform.position;
        }
    }
}