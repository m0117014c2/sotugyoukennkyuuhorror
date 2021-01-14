using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash : MonoBehaviour
{
    [SerializeField]
    private Image image = default;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    //void Update()
    //{
    //    if ( !isFlash)
    //    {
    //        return;
    //    }
    //    if (Input.GetMouseButtonDown(0))
    //    {
            
    //    }
    //    else
    //    {
    //        image.color = Color.Lerp(image.color, Color.clear, Time.deltaTime);
    //    }
    //}

    public void Show(float duration)
    {
        Debug.Log("フラッシュ演出!");
        gameObject.SetActive(true);
        StartCoroutine(Anim(duration));
    }
    public IEnumerator Anim(float duration)
    {
        
        var t = 0f;
        image.color = new Color(1, 1, 1, 1);
        
        
        while (t < duration)
        {
            t += Time.deltaTime;
            image.color = Color.Lerp(image.color, Color.clear, t/duration);
            yield return null;
        }
        gameObject.SetActive(false);
    }


}
