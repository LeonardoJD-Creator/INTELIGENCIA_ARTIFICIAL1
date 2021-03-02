using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingState : FunctionsFSM
{
    float nextFire;         //Acumular el tiempo para el proximo disparo
    float rateFire = 1f;    //Cada cuanto tiene que disparar

    public override void EnterState(AgenteEstatico agent)
    {
        //Código para cuando entra al estado de atacar
        Debug.Log("Estado de atacar");
        agent.agentStatus = AgentState.Attacking;

        //agent.FireBullet();
        nextFire = Time.time + rateFire;
    }

    public override void UpdateState(AgenteEstatico agent)
    {
        if (agent.targetDetected) 
        {
            
            var lookRotation = Quaternion.LookRotation(agent.targetObj.transform.position - agent.transform.position);
           
            agent.transform.rotation = Quaternion.Slerp(agent.transform.rotation, lookRotation, agent.speedRotation * Time.deltaTime);

           
            if (nextFire < Time.time)
            {
                agent.FireBullet(); 
                nextFire = Time.time + rateFire; 
            }
        }
        else
        {
            agent.TransitionToState(agent.idleState);
        }
    }
}
