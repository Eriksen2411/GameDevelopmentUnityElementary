using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    public GameObject player;
    public GameObject health_0;
    public GameObject health_1;
    public GameObject health_2;
    public GameObject[] healthbar;


    public int playerHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = player.GetComponent<Health>().currentLives;
        healthbar = new GameObject[] { health_0, health_1, health_2 };
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            playerHealth = player.GetComponent<Health>().currentLives;
            for (int i = 0; i < 3; i++)
            {
                if (i < playerHealth)
                {
                    healthbar[i].SetActive(true);
                }
                else
                {
                    healthbar[i].SetActive(false);
                }
            }
        }
    }
}
