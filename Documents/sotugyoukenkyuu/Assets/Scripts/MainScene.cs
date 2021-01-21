using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class MainScene : MonoBehaviour
{
    [SerializeField]
    private Receiver receiver;

    [SerializeField]
    private Flash flash;

    [SerializeField]
    private Full full;

    [SerializeField]
    private FirstPersonController player;

    private bool playHorror = false;
    private float playInterval = default;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(StartConnect());
        receiver.AddListener(OnHeartOver);
        player.AddAnimCallback(Full);
    }

    private void Update()
    {
        if ( playHorror )
        {
            playHorror = false;
            if ( playInterval <= 0)
            {
                playInterval = 5;
                PlayerHeartRateData.GetInstance().RecordHeartRateAtBikuri();
                StartCoroutine(PlayHorror());
            }
        }

        if ( playInterval >= 0 )
        {
            playInterval -= Time.deltaTime;
        }
    }

    IEnumerator StartConnect()
    {
        yield return new WaitForSeconds(1);
        receiver.Connect();
        yield return new WaitForSeconds(1);
        receiver.StartSend();//TODO 本番の場合は削除
        yield break;
    }

    private void OnHeartOver()
    {
        playHorror = true;
    }

    public IEnumerator PlayHorror()
    {
        float r = Random.Range(0, 1.0f);
        //Flash();
        
        if (r > 0.5)
        {
            player.PlayHorrorSound();
        }
        else {
            Flash();
        }
        
        yield break;
    }

    private void Flash()
    {
        flash.Show(3);
    }

    private void Full(bool isFirst)
    {
        if (isFirst)
        {
            PlayerHeartRateData.GetInstance().RecordHeartRateAtBikuri1();
        }
        else
        {
            PlayerHeartRateData.GetInstance().RecordHeartRateAtBikuri2();
        }
        full.Show(2);
    }
}
