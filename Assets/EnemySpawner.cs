using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private float minSpawnTime;
    [SerializeField]
    private float maxSpawnTime;

    private float timeTill;
    // Start is called before the first frame update
    void Awake()
    {
        setTime();
    }

    // Update is called once per frame
    void Update()
    {
        timeTill -= Time.deltaTime;
        if (timeTill <=0){

            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            setTime();
        }
    }

    private void setTime(){

        timeTill = Random.Range(minSpawnTime,maxSpawnTime);
    }
}
