using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SampleScene : MonoBehaviour
{
    [SerializeField]
    private Button connectButton;

    [SerializeField]
    private Button startSendButton;

    [SerializeField]
    private Button stopSendButton;

    [SerializeField]
    private Receiver receiver;

    [SerializeField]
    private Server server;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Connect()
    {
        receiver.Connect();
    }

    public void StartSend()
    {
        receiver.StartSend();
    }

    public void StopSend()
    {
        receiver.StopSend();
    }

    public void Save()
    {
        receiver.SaveToFile();
    }
}
