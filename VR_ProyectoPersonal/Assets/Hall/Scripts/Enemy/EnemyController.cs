using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private EnemyScriptStorage _enemyScriptStorage;

    private void Awake()
    {
        _enemyScriptStorage = GetComponent<EnemyScriptStorage>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _enemyScriptStorage.NavMeshAgent.SetDestination(GameObject.FindWithTag("Player").transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        AnimationControl();
    }

    private void AnimationControl()
    {
        _enemyScriptStorage.Animator.SetFloat("NavMeshVelocity", _enemyScriptStorage.NavMeshAgent.velocity.magnitude);
    }
}
