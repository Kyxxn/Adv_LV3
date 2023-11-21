using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float createTime = 1;

    private float currentTime; // 현재 시간

    private void Start()
    {
        createTime = UnityEngine.Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 시간이 흐름
        currentTime += Time.deltaTime;
        // 2. 현재시간이 일정시간이 되면
        if (currentTime > createTime)
        {
            // 3. 적을 공장에서 생성
            int index = UnityEngine.Random.Range(0, animalPrefabs.Length); // 랜덤 인덱스
            GameObject animal = Instantiate(animalPrefabs[index]);
            animal.transform.position = transform.position;
            currentTime = 0;
        }
    }
}
