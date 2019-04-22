using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private PlayerHealth playerHealth;

    public GameObject[] enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


    void Start ()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        int enemyIndex = Random.Range(0, enemy.Length);

        Instantiate (enemy[enemyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
