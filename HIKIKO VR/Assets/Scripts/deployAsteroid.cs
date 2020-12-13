using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroid : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float RespawnTime = 1f;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AsteroidWave());
        //RespawnTime = 1f;
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-7f, 7f), 60f);

        
    }
    // Update is called once per frame
   IEnumerator AsteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(RespawnTime);
            spawnEnemy();
        }
       
    }

    
}
