using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    private void Start()
    {
        if (PlayerController.instance == null)
        {
            Instantiate(player);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}