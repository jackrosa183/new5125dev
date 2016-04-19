using UnityEngine;
using System.Collections;

public class playaudiomovie : MonoBehaviour {
	public GameObject other;
	void Example() {
		other.GetComponent<AudioSource>().Play();
	}
}