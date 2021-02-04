using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{

    public GameObject[] roadPrefabs;
    public float spawnZ = 0;
    public float roadLength = 0;
    public int numberOfPrefabs = 3;

    public Transform playerTransform;

    private List<GameObject> activeRoadPrefab = new List<GameObject>(); 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            if (i == 0) {
                SpawnRoad(0);
            } else {
                SpawnRoad(Random.Range(0, roadPrefabs.Length));
            }
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z - 35 > spawnZ - (numberOfPrefabs * roadLength)) {
            SpawnRoad(Random.Range(0, roadPrefabs.Length));
            DeleteOldRoadPrefab();
        }
    }

    public void SpawnRoad(int roadIndex) {
        GameObject newRoadPrefab = Instantiate(roadPrefabs[roadIndex], transform.forward * spawnZ, transform.rotation);
        activeRoadPrefab.Add(newRoadPrefab);
        spawnZ += roadLength;
    }

    private void DeleteOldRoadPrefab() {
        Destroy(activeRoadPrefab[0]);
        activeRoadPrefab.RemoveAt(0);
    }

}
