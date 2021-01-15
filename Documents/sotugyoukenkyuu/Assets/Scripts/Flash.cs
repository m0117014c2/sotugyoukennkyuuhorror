using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash : MonoBehaviour
{
    [SerializeField]
    private Image image = default;

    [SerializeField]
    private Color[] colors = default;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    public void Show(float duration)
    {
        Debug.Log("フラッシュ演出!");
        gameObject.SetActive(true);
        StartCoroutine(Anim(duration));
    }
    public IEnumerator Anim(float duration)
    {
        Debug.Log("Flash start");
        var t = 0f;
        int n = Random.Range(1, colors.Length);
        image.color = colors[n];
        Debug.Log("color =" +image.color);
        while (t < duration)
        {
            t += Time.deltaTime;
            image.color = Color.Lerp(image.color, Color.clear, Time.deltaTime);
            yield return null;
        }
        gameObject.SetActive(false);
        Debug.Log("Flash end");
    }


}
