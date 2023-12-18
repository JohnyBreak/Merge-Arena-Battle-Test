using UnityEngine;
using Zenject;

public class ButtonSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private Save _save;

    [Inject]
    private void Construct(Save save)
    {
        _save = save;
    }

    public void PlayOneshot(AudioClip clip) 
    {
        if (_save.ShouldPlayButtonSound() == false) return;

        _audioSource.PlayOneShot(clip);
    }
}
