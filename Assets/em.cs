using System.Collections;
using UnityEngine;

public class em : MonoBehaviour
{
    public GameObject em2Prefab;
    public float spawnInterval = 0.6f;
    public float minX = -8f;
    public float maxX = 8f;
    public float spawnY = 6f;

    private GameObject emObject;

    void Start()
    {
        StartCoroutine(SpawnSpheres());
    }

    private IEnumerator SpawnSpheres()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), spawnY, 0);
            emObject = Instantiate(em2Prefab, spawnPosition, Quaternion.identity);
            emObject.tag = "Clone"; // 원본은 안사라지게 하기 위해서 tag 추가
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
