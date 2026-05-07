using UnityEngine;

public class audioplay : MonoBehaviour
{
    public AudioSource ad;

    public AudioClip clip;

    private void Start()
    {
        ad.clip = clip;
        ad.Play();
    }
}

