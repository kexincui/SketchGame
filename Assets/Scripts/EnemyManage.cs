using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManage : MonoBehaviour
{

    private List<GameObject> enemies = new List<GameObject>();

    //void Update()
    //{
    //    Debug.Log(enemies.Count);
    //}

    public void AddEnemy(GameObject enemy)
    {
        enemies.Add(enemy);
    }

    public void DeleteEnemy(GameObject enemy)
    {
        enemies.Remove(enemy);
    }
}
