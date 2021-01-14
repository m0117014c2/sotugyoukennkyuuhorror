using UnityEngine;
using System.Collections;

// ★追加
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour
{

	// ★追加
	// 「public」を必ずつけること（ポイント）
	public void OnStartButtonClicked()
	{
		PlayerHeartRateData.GetInstance().SaveToFile();
		SceneManager.LoadScene("Save");
	}
}