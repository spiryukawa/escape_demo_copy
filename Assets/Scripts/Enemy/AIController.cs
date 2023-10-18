using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Adventure.Enemy
{
	public class AIController : MonoBehaviour
	{
		public NavMeshAgent _agent;

		void Start()
		{
			_agent = this.GetComponent<NavMeshAgent>();
		}

		void Update()
		{
			
		}
	}

}
