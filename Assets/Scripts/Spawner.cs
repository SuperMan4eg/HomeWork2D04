using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _amountEnemy = 100;

    private int _delay = 2;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        var WaitForTwoSeconds = new WaitForSeconds(_delay);

        for (int i = 0; i < _amountEnemy; i++)
        {
            Transform _spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            Instantiate(_template, _spawnPoint.position, _spawnPoint.rotation);

            yield return WaitForTwoSeconds;
        }
    }
}
