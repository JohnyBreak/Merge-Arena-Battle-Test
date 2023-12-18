using UnityEngine;
using Zenject;

public class CurrencyTest : MonoBehaviour
{
    private Wallet _wallet;
    [Inject]
    private void Construct(Wallet w)
    {
        _wallet = w;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _wallet.AddTickets(50);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(_wallet.TryRemoveTickets(50));
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(_wallet.TryRemoveTickets(70));
        }
    }
}
