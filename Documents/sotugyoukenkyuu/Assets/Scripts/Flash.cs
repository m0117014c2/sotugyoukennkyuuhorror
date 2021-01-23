using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Flash : MonoBehaviour
{
    [SerializeField]
    private Image image = default;

    [SerializeField]
    private Color[] colors = default;

    private Queue<Color> colorQueue = new Queue<Color>();

    private void Awake()
    {
        gameObject.SetActive(false);
        var shuffle = colors.OrderBy(_ => Guid.NewGuid());
        foreach (var c in shuffle)
        {
            colorQueue.Enqueue(c);
        }
    }

    public void Show(float duration)
    {
        Debug.Log("フラッシュ演出!");
        gameObject.SetActive(true);
        StartCoroutine(Anim(duration));
    }
    public IEnumerator Anim(float duration)
    {
        if ( colorQueue.Count == 0)
        {
            yield break;
        }
        var t = 0f;
        
        image.color = colorQueue.Dequeue();
        
        while (t < duration)
        {
            t += Time.deltaTime;
            image.color = Color.Lerp(image.color, Color.clear, Time.deltaTime);
            yield return null;
        }
        gameObject.SetActive(false);
    }


}
