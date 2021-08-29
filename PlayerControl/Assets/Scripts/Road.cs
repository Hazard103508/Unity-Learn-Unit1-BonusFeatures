using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private GameObject ObstaclesFolder;
    [SerializeField] private GameObject[] obstacles;
    // Start is called before the first frame update
    void Start()
    {
        var positions = new int[] { 50, 100, 150, 200 };
        Array.ForEach(positions, z =>
        {
            int index = UnityEngine.Random.Range(0, obstacles.Length);
            var obstacle = Instantiate(obstacles[index], ObstaclesFolder.transform);
            obstacle.transform.localPosition = new Vector3(0, 0, z);
        });
    }
}
