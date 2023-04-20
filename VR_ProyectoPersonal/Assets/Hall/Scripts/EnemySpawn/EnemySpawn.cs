using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private List<GameObject> enemiesList;

    private void Start()
    {
        StartCoroutine(SpawnControl_Coroutine());
    }

    private IEnumerator SpawnControl_Coroutine()
    {
        yield return new WaitForSeconds(3f);

        foreach (GameObject enemy in enemiesList)
        {
            if (enemy == null)
            {
                enemiesList.Remove(enemy);
            }
        }

        while (enemiesList.Count < 3)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            enemiesList.Add(enemy);
            yield return null;
        }
        
        yield return null;
    }
}
