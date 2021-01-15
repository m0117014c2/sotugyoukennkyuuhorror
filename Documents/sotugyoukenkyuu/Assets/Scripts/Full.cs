using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Full : MonoBehaviour
{
    [SerializeField]
    private Image image1 = default;

    [SerializeField]
    private Image image2 = default;

    [SerializeField] private AudioClip[] m_horrorSounds;

    [SerializeField] private AudioSource m_AudioSource;

    private bool isFirst = true;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    public void Show(float duration)
    {
        Debug.Log("いっぱいに画像を表示!");
        gameObject.SetActive(true);
        StartCoroutine(Anim(duration));
    }
    public IEnumerator Anim(float duration)
    {
        
        m_AudioSource.clip = m_horrorSounds[isFirst ? 0:1];
        m_AudioSource.PlayOneShot(m_AudioSource.clip);

        image1.gameObject.SetActive(isFirst);
        image2.gameObject.SetActive(!isFirst);
        var t = 0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            yield return null;
        }

        isFirst = false;
        gameObject.SetActive(false);
    }


}
