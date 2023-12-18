using System;
using UnityEngine;
using Zenject;

public class Save
{
    private IPersistentData _persistentData;

    [Inject]
    private void Construct(IPersistentData data)
    {
        _persistentData = data;
    }


    public event Action<bool> MusicStateSavedEvent;

    public bool ShouldPlayMusic() 
    {
        return PlayerPrefs.GetInt("Music", 1) == 1? true: false;
    }

    public void SaveMusicState(bool toggle) 
    {
        if (toggle) PlayerPrefs.SetInt("Music", 1);
        else PlayerPrefs.SetInt("Music", 0);

        MusicStateSavedEvent?.Invoke(toggle);
    }

    public bool ShouldPlayButtonSound()
    {
        return PlayerPrefs.GetInt("ButtonSound", 1) == 1 ? true : false;
    }

    public void SaveButtonSoundState(bool toggle)
    {
        if (toggle) PlayerPrefs.SetInt("ButtonSound", 1);
        else PlayerPrefs.SetInt("ButtonSound", 0);
    }

    public int GetTicketAmount() 
    {
        return _persistentData.PlayerData.Tickets;
        //return PlayerPrefs.GetInt("CurrencyAmount", 0);
    }

    public void SetTicketAmount(int amount)
    {
        _persistentData.PlayerData.Tickets = amount;
        //PlayerPrefs.SetInt("CurrencyAmount", amount);
    }

    public void SaveData()
    {
        //PlayerPrefs.SetInt("CurrencyAmount", amount);
    }
}
