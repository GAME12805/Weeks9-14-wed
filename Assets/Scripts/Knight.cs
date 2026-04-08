using Unity.Cinemachine;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public CinemachineCollisionImpulseSource impulse;
    public AudioSource SFX;
    public AudioClip chime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Footstep()
    {
        //Debug.Log("Step!");
        SFX.pitch = Random.Range(0.8f, 1.2f);
        SFX.PlayOneShot(chime);
        impulse.GenerateImpulseWithVelocity(Random.insideUnitCircle);
    }
}
