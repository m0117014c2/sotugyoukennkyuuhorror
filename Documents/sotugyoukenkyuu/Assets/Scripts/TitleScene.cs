using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour
{
    [SerializeField]
    private Button startSendButton;

    [SerializeField]
    private Receiver receiver;

    [SerializeField]
    private AudioSource au;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(StartConnect());
    }

    IEnumerator StartConnect()
    {
        yield return new WaitForSeconds(1);
        receiver.Connect();
        yield return new WaitForSeconds(1);
        receiver.StartSend();//TODO 本番の場合は削除
        yield break;

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void OnStartButtonClicked()
    {
        SaveTitleHeartRate();
        SceneManager.LoadScene("mainscene");
    }

    private void SaveTitleHeartRate()
    {
        PlayerHeartRateData.GetInstance().RecordHeartRateAtTitle();
    }

    public void Play()
    {
        au.Play(0);
    }
}
