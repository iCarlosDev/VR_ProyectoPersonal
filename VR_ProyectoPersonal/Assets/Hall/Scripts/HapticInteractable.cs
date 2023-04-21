using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    [SerializeField] private XRBaseController controller;
    [SerializeField] private float intensity;
    [SerializeField] private float time;

    void SendHaptics()
    {
        if (controller != null)
        {
            controller.SendHapticImpulse(intensity, time);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("EnemyCollider"))
        {
            SendHaptics();
        }
    }
}
