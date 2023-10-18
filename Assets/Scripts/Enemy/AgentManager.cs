using Adventure.Enemy;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    [SerializeField] GameObject[] _agents = null;
    [SerializeField] GameObject _target = null;


    void Update()
    {
        foreach (GameObject agent in _agents)
        {
            agent.GetComponent<AIController>()._agent.SetDestination(_target.transform.position);
		}
    }
}
