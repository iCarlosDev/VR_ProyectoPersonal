using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    [SerializeField]
    XRBaseController controller;

    void SendHaptics()
    {
        if (controller != null)
        {
            controller.SendHapticImpulse(0.7f, 0.1f);
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
