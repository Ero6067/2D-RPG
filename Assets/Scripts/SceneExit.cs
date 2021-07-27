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
    public SceneStart theEntrance;

    private void Start()
    {
        //theEntrance.lastE
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (SceneManager.GetActiveScene().name != sceneToLoad)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                PlayerPrefs.SetString("LastExitName", exitName.ToString());
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}