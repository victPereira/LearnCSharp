using System.Collections;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float countdownDuration = 3f;
    public TextMeshProUGUI countdownText;

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        int countdown = (int)countdownDuration;

        while (countdown > 0)
        {
            countdownText.text = countdown.ToString();
            yield return new WaitForSeconds(1f);
            countdown--;
        }

        countdownText.text = "Go!";
        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false);
        // Adicione aqui a lógica para iniciar o jogo
    }
}
