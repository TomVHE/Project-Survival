using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    private int currWave;
    public int currEnemy;
    public int maxEnemy;
    public GameObject zombie;
    public List<GameObject> spawnLoc = new List<GameObject>();

	void Start () {
        maxEnemy = 24;
	}
	
	void Update () {
        EnemyCheck();
	}

    void EnemyCheck() {

        if (currEnemy == 0) {
            StartCoroutine(NextWave());
            for (int i = 0; i < maxEnemy; i++) {
                int randomSpawnLoc = Random.Range(0, spawnLoc.Count);
                Instantiate(zombie, spawnLoc[randomSpawnLoc].transform.position, Quaternion.identity);
                currEnemy++;
            }
        }
    }
    IEnumerator NextWave() {
        print("Next Wave in 5 seconds");
        yield return new WaitForSeconds(5);
        print("Wave Starting");
    }
}
