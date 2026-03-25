using UnityEngine;

public class Knight : MonoBehaviour
{
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
        SFX.pitch = Random.Range(0.9f, 1.1f);
        SFX.PlayOneShot(chime);
    }
}
