using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Full : MonoBehaviour
{
    [SerializeField]
    private Image image = default;

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
        var t = 0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            yield return null;
        }
        gameObject.SetActive(false);
    }


}
