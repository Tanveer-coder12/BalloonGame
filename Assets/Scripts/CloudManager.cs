using System.Collections;
using UnityEngine;

public class CloudManager : MonoBehaviour
{
    public GameObject []cloudsprefab;
    public Transform SpawnPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawningClouds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator SpawningClouds()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            float randomrange = Random.Range(-2.5f, 2.5f);
                
            int i = Random.Range(0, cloudsprefab.Length);    
            Instantiate(cloudsprefab[i], SpawnPos.transform.position = new Vector2(randomrange, transform.position.y), Quaternion.identity);
                   
           
        }
    }
}
