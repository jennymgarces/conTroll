using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyFace;
    public float spawnTime = 3f;            // How long between each spawn.
    //public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);    //function to invoke the void

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void Spawn ()
    {
        // If the player has no health left...
        /* if(playerHealth.currentHealth <= 0f)
         {
             // ... exit the function.
             return;
         }
 */
        // Find a random index between zero and one less than the number of spawn points.
        float spawnPointX = Random.Range (-2, 2.5f);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate (enemyFace,new Vector3(spawnPointX,6,0), transform.rotation);
        //Instantiate (enemyFace, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        
    }
    
    // Function called when the object goes out of the screen
   /* void OnBecameInvisible() {
        // Destroy the enemy
        Destroy(gameObject);
    }*/
}
