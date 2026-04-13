using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawnerCContorler  : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int selectedLevel;
    public static bool[] compltetLevels;
        public bool[] compltetLevelsCop;

    public int enemyKillCount=0; // ändras extrent

    public float minX = -8f;
    public float maxX = 8f;

    public float spawAmount = 10;
    public float spawnInterval = 1.5f;
    private float timer = 0f;

    void Start()
    {
        if(SceneManager.GetActiveScene().name=="level1")
        Debug.Log("tah");
    }
    void Update()
    {
        
        timer += Time.deltaTime;

        if (timer >= spawnInterval && spawAmount-- >= -1) // 2 extra enemien pga = och -1
        {
            SpawnEnemy();
            timer = 0f;
        }

        if(!(compltetLevels[0] && compltetLevels[1] && compltetLevels[2] && compltetLevels[3] && compltetLevels[4]) && SceneManager.GetActiveScene().name == "level6")
        {
            Debug.Log(compltetLevels[0]);
            Debug.Log(compltetLevels[1]);
            Debug.Log(compltetLevels[2]);
            Debug.Log(compltetLevels[3]);
            Debug.Log(compltetLevels[4]);
            Debug.Log(compltetLevels[5]);
            SceneManager.LoadScene("select level");
        }

        if(SceneManager.GetActiveScene().name=="level1")
            selectedLevel=1;
        if(SceneManager.GetActiveScene().name=="level2")
            selectedLevel=2;
        if(SceneManager.GetActiveScene().name=="level3")
            selectedLevel=3;
        if(SceneManager.GetActiveScene().name=="level4")
            selectedLevel=4;
        if(SceneManager.GetActiveScene().name=="level5")
            selectedLevel=5;
        if(SceneManager.GetActiveScene().name=="level6")
            selectedLevel=6;

        if(enemyKillCount>=4) // det här är 10 men det träffar 3 gånger per
        {
            SceneManager.LoadScene("select level");
            compltetLevels[selectedLevel]=true;
        }
        if(compltetLevels[6]==true)
            SceneManager.LoadScene("victory");

    }

    void SpawnEnemy()
    {
        float randomX = UnityEngine.Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, 10f, 0f);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}