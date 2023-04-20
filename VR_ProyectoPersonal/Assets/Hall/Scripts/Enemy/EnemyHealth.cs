using System;
using FIMSpace.BonesStimulation;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private EnemyScriptStorage _enemyScriptStorage;

    private void Awake()
    {
        _enemyScriptStorage = GetComponent<EnemyScriptStorage>();
    }

    public void Die()
    {
        if (_enemyScriptStorage.Animator.enabled)
        {
            _enemyScriptStorage.Animator.enabled = false;
            foreach (Rigidbody ragdollRigidbody in _enemyScriptStorage.RagdollRigidbodiesList)
            {
                ragdollRigidbody.isKinematic = false;
            }

            foreach (BonesStimulator boneStimulator in _enemyScriptStorage.BonesStimulatorsList)
            {
                boneStimulator.enabled = false;
            }
        }
    }
}
