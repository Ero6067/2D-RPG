using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    [SerializeField]
    private Levels lastExitName;

    // Start is called before the first frame update
    private void Start()
    {
        if (PlayerPrefs.GetString("LastExitName") == lastExitName.ToString())
        {
            PlayerController.instance.transform.position = transform.position;
        }
    }
}