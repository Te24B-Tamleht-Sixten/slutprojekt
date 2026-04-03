using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public int enemyKillCount=0;

    public float minX = -8f;
    public float maxX = 8f;

    public float spawAmount = 10;
    public float spawnInterval = 1.5f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval && spawAmount-- > 0)
        {
            SpawnEnemy();
            timer = 0f;
        }
        if(enemyKillCount==10)
            SceneManager.LoadScene("select level");

    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, 10f, 0f);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}