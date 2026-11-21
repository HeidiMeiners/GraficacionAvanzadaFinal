using UnityEngine;
using UnityEngine.InputSystem; 

public class ExplosionTrigger : MonoBehaviour
{
    private ParticleSystem[] particles;

    void Awake()
    {
        particles = GetComponentsInChildren<ParticleSystem>();
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ActivarExplosion();
        }
    }

    public void ActivarExplosion()
    {
        foreach (ParticleSystem ps in particles)
        {
            ps.Play();
        }
    }
}