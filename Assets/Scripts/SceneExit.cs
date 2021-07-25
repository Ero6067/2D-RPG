using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public partial class SceneExit : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    [SerializeField]
    private Levels exitName;

    [SerializeField]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetString("LastExitName", exitName.ToString());
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}