using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class MainScene : MonoBehaviour
{
    [SerializeField]
    private Receiver receiver;

    [SerializeField]
    private AudioSource au;

    [SerializeField]
    private FirstPersonController player;

    private bool playHorrorSound = false;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(StartConnect());
        receiver.AddListener(OnHeartOver);
    }

    private void Update()
    {
        if ( playHorrorSound)
        {
            playHorrorSound = false;
            StartCoroutine(PlaySound());
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
        playHorrorSound = true;
    }

    public IEnumerator PlaySound()
    {
        player.PlayHorrorSound();
        yield break;
    }
}
