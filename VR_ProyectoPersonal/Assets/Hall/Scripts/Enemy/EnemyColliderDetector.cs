using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnemyColliderDetector : MonoBehaviour
{
    [SerializeField] private EnemyScriptStorage _enemyScriptStorage;

    private void Start()
    {
        _enemyScriptStorage = GetComponentInParent<EnemyScriptStorage>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Weapon"))
        {
            Debug.Log(collision.relativeVelocity.magnitude);
            if (collision.relativeVelocity.magnitude > 10f)
            {
                _enemyScriptStorage.EnemyHealth.Die();   
            }
        }
    }
}
