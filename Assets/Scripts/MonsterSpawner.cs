using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    [SerializeField]
    private Transform leftPos, rightPos;
    
    private GameObject spawnedMonster;
    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters(){
        // Corouytines: Call over an interval of time
      while(true){
        yield return new WaitForSeconds(Random.Range(1,5));
        randomIndex = Random.Range(0,monsterReference.Length);
        randomSide = Random.Range(0,2);
        spawnedMonster = Instantiate(monsterReference[randomIndex]);

        // Left Side
        if(randomSide == 0){
            spawnedMonster.transform.position = leftPos.position;
            spawnedMonster.GetComponent<Monster>().speed = Random.Range(2,5) *  LevelScript.LevelValue;
        }else{
            // Right side
            spawnedMonster.transform.position = rightPos.position;
            // the negative sign is to make the monster go to the oposite side
            spawnedMonster.GetComponent<Monster>().speed = -Random.Range(2,5) * LevelScript.LevelValue;
            spawnedMonster.transform.localScale = new Vector3(-1f,1f,1f);
        }
      } // while
    }
}
