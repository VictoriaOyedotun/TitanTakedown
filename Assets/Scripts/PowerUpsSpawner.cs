using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] powerupsReference;

    [SerializeField]
    private Transform onePos, twoPos,threePos,fourPos,fivePos,sixPos,sevenPos,ninePos;
    
    private GameObject spawnedPowerups;
    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPowerups());
    }

    IEnumerator SpawnPowerups(){
        // Corouytines: Call over an interval of time
      while(true){
        yield return new WaitForSeconds(Random.Range(40,100));
        randomIndex = Random.Range(0,powerupsReference.Length);
        randomSide = Random.Range(0,8);
        spawnedPowerups = Instantiate(powerupsReference[randomIndex]);

        // Left Side
        if(randomSide == 0){
            spawnedPowerups.transform.position = onePos.position;
        }else if(randomSide == 1){
            // Right side
            spawnedPowerups.transform.position = twoPos.position;
            // the negative sign is to make the monster go to the oposite side
        }else if(randomSide == 2){
            // Right side
            spawnedPowerups.transform.position = threePos.position;
            // the negative sign is to make the monster go to the oposite side
        }else if(randomSide == 3){
            // Right side
            spawnedPowerups.transform.position = fourPos.position;
            // the negative sign is to make the monster go to the oposite side
        }else if(randomSide == 4){
            // Right side
            spawnedPowerups.transform.position = fivePos.position;
            // the negative sign is to make the monster go to the oposite side
        }else if(randomSide == 5){
            // Right side
            spawnedPowerups.transform.position = sixPos.position;
            // the negative sign is to make the monster go to the oposite side
        }else if(randomSide == 6){
            // Right side
            spawnedPowerups.transform.position = sevenPos.position;
            // the negative sign is to make the monster go to the oposite side
        }else if(randomSide == 7){
            // Right side
            spawnedPowerups.transform.position = ninePos.position;
            // the negative sign is to make the monster go to the oposite side
        }
      } // while
    }
}
