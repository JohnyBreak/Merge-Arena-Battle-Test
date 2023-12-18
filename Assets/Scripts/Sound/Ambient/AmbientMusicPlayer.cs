using UnityEngine;
using Zenject;

public class AmbientMusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private Save _save;

    [Inject]
    private void Construct(Save save)
    {
        _save = save;
        _save.MusicStateSavedEvent += OnStateChanged;
    }

    private void Awake()
    {
        _audioSource.loop = true;
        Play(_audioSource.clip);
    }

    private void OnDestroy()
    {
        _save.MusicStateSavedEvent -= OnStateChanged;
    }

    private void OnStateChanged(bool toggle) 
    {
        if(toggle) Play(_audioSource.clip);
        else StopMusic();
    }

    public void StopMusic() 
    {
        _audioSource.Stop();
    }

    public void Play(AudioClip clip)
    {
        if (_save.ShouldPlayMusic() == false) return;

        _audioSource.clip = clip;
        _audioSource.Play();
    }
}
