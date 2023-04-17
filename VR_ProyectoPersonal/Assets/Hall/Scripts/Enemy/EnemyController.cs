using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private NavMeshAgent _navMeshAgent;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent.SetDestination(GameObject.FindWithTag("Player").transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        AnimationControl();
    }

    private void AnimationControl()
    {
        _animator.SetFloat("NavMeshVelocity", _navMeshAgent.velocity.magnitude);
    }
}
