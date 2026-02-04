using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval ;
    private float spawntime;
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
        spawntime=Time.time + spawnInterval;


    }

    void Spawn()
    {
        Instantiate(obstaclePrefab,transform.position , transform.rotation);
    }
}
