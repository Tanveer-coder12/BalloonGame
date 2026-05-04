using UnityEngine;

public class audioplay : MonoBehaviour
{
    public AudioSource ad;

    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
      
    }
    private void Start()
    {
        ad.clip = clip;
        ad.Play();
    }
}

