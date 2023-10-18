using System.Collections;
using System.Collections.Generic;
using Adventure.Player;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace Adventure.Scene
{
	public class CollisionSceneTransition : MonoBehaviour
	{
		public string NextSceneName;
		public GameObject TargetObject;

		private SceneLoader _sceneLoader;

		void Start()
		{
			GameObject sceneObj = GameObject.Find("SceneLoader");
			_sceneLoader = sceneObj.GetComponent<SceneLoader>();
		}
		private void OnCollisionEnter(Collision collision)
		{
			if (collision.gameObject == TargetObject)
			{
				_sceneLoader.LoadNextScene(NextSceneName);
			}
		}
	}

}
