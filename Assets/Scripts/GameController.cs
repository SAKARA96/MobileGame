using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject rock;
    public Vector3 spawnValue;
    public int rockCount;
    public float startWait;
    public float spawnWait;
    public float waveWait;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds (startWait);
        while(true){
            for(int i = 0; i < rockCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x,spawnValue.x),spawnValue.y,spawnValue.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(rock, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
            }
            yield return new WaitForSeconds (waveWait);
        }
    }

}
