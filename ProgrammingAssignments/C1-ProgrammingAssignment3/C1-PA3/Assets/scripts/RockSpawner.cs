using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject[] countofRocks;

    // Rock created for spawning
    [SerializeField]
    GameObject prefabRock;

    //Sprite colors to render the prefab rock
    [SerializeField]
    Sprite rockSprite0;
    [SerializeField]
    Sprite rockSprite1;
    [SerializeField]
    Sprite rockSprite2;

    // spawn control parameters
    const float SpawnTime = 1;
    Timer spawnTimer;


    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = SpawnTime;
        spawnTimer.Run();

        SpawnRock();
    }

    /// <summary>
    /// Update is called once per frame
    /// If the number of rocks per second is less than 3, new rock is spawned
    /// </summary>
    void Update()
    {
        countofRocks = GameObject.FindGameObjectsWithTag("rock");
        if (countofRocks.Length < 3)
        {
            //print(spawnTimer);
            SpawnRock();
        }

        //if ( !spawnTimer.Finished)
        //{

        //    countofRocks = GameObject.FindGameObjectsWithTag("rock");
        //    if (countofRocks.Length < 3)
        //    {
        //        SpawnRock();
        //    }
        //}
        //else if(spawnTimer.Finished)
        //{
        //    // change spawn timer duration and restart
        //    //spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        //    spawnTimer.Run();
        //}

    }

    /// <summary>
    /// Spawns a new rocks at a random location
    /// </summary>
    void SpawnRock()
    {
        // generate random location and create new teddy bear
        Vector3 location = new Vector3( Screen.width / 2, Screen.height / 2, - Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        GameObject rock = Instantiate( prefabRock);
        rock.transform.position = worldLocation;
        rock.gameObject.tag = "rock";

        // renders sprite randomly to the spawned rock
        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if( spriteNumber == 0)
        {
            spriteRenderer.sprite = rockSprite0;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = rockSprite1;
        }
        else
        {
            spriteRenderer.sprite = rockSprite2;
        }
    }
}
