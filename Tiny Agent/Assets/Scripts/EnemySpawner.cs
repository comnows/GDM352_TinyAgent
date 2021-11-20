using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyList;
    public GameObject[] spawnPoint;
    [SerializeField] GameObject enemyPrefabs;

    private int index;

    // Update is called once per frame
    void Update()
    {
        if(enemyList.Count == 0)
        {
            index = Random.Range(0, spawnPoint.Length);
            GameObject enemy = Instantiate(enemyPrefabs, spawnPoint[index].transform.position, Quaternion.identity);
            enemyList.Add(enemy);
        }
    }

    public void EnemyDie(GameObject enemy)
    {
        enemyList.Remove(enemy);
    }
}
