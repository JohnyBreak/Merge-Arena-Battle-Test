using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ButtonClickSound : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    private Button _button;
    private ButtonSoundPlayer _soundPlayer;

    [Inject]
    private void Construct(ButtonSoundPlayer player) 
    {
        _soundPlayer = player;
    }

    void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Onclick);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(Onclick);
    }

    private void Onclick() 
    {
        _soundPlayer.PlayOneshot(_audioClip);
    }
}
