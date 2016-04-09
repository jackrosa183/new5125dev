using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	private float endtime = 50.0f;  // 60 seconds

	IEnumerator Start()
	{
	     yield return new WaitForSeconds(endtime);
		SceneManager.LoadScene(1);
	}
}
