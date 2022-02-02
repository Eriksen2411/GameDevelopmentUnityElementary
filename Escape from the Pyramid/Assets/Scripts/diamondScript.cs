using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamondScript : MonoBehaviour
{
    public GameObject gameLevelManager;
    private LevelManager levelManager;
    public GameObject diamondSpawning;
    private diamondspawning diamondspawn;
    public int diamondValue;
    public bool takenByPlayer = false;

    void Awake()
    {
        levelManager = gameLevelManager.GetComponent<LevelManager>();
        diamondspawn = diamondSpawning.GetComponent<diamondspawning>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager> ();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            levelManager.AddScore(diamondValue);
            Destroy(gameObject);
            Debug.Log("Hit");
            diamondspawn.nextSpawn = Time.time;
        }
    }
}
