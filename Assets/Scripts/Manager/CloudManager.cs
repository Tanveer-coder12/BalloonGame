using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class CloudManager : MonoBehaviour
{
    public GameObject []cloudsprefab;
    public Transform SpawnPos;
    public int limitedclouds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawningClouds());
    }
    public IEnumerator SpawningClouds()
    {
        for (int j = 0; j < limitedclouds; j++)
        {
            yield return new WaitForSeconds(1.5f);
            float randomrange = Random.Range(-2.5f, 2.5f);

            int i = Random.Range(0, cloudsprefab.Length);
            GameObject Clouds = Instantiate(cloudsprefab[i], SpawnPos.transform.position = new Vector2(randomrange, transform.position.y), Quaternion.identity);

        }
                  
          
        
    }
}
