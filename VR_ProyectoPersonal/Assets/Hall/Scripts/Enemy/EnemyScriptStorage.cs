using System;
using System.Collections;
using System.Collections.Generic;
using FIMSpace.BonesStimulation;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScriptStorage : MonoBehaviour
{
    [Header("--- COMPONENTS ---")]
    [Space(10)]
    [SerializeField] private Animator _animator;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    [SerializeField] private List<Rigidbody> ragdollRigidbodiesList;
    [SerializeField] private List<BonesStimulator> bonesStimulatorsList;

    [Header("--- SCRIPTS ---")]
    [Space(10)]
    [SerializeField] private EnemyController _enemyController;
    [SerializeField] private EnemyHealth _enemyHealth;

    //GETTERS && SETTERS//
    public Animator Animator => _animator;
    public NavMeshAgent NavMeshAgent => _navMeshAgent;
    public List<Rigidbody> RagdollRigidbodiesList => ragdollRigidbodiesList;
    public List<BonesStimulator> BonesStimulatorsList => bonesStimulatorsList;
    public EnemyController EnemyController => _enemyController;
    public EnemyHealth EnemyHealth => _enemyHealth;

    ///////////////////////////////////////////////////////////////

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _enemyController = GetComponent<EnemyController>();
        _enemyHealth = GetComponent<EnemyHealth>();
    }

    private void Start()
    {
        ragdollRigidbodiesList = new List<Rigidbody>();
        ragdollRigidbodiesList.AddRange(GetComponentsInChildren<Rigidbody>());
        bonesStimulatorsList.AddRange(GetComponentsInChildren<BonesStimulator>());

        foreach (Rigidbody rigidbody in ragdollRigidbodiesList)
        {
            rigidbody.gameObject.AddComponent<EnemyColliderDetector>();
        }
    }
}
