using System;
using Assets.Scripts.GameManager;
using Assets.Scripts.IAJ.Unity.DecisionMaking.GOB;
using UnityEngine;

namespace Assets.Scripts.DecisionMakingActions
{
    public class PickUpChest : WalkToTargetAndExecuteAction
    {

        public PickUpChest(AutonomousCharacter character, GameObject target) : base("PickUpChest",character,target)
        {
        }


        public override float GetGoalChange(Goal goal)
        {
            var change = base.GetGoalChange(goal);
            //TODO: implement
            throw new NotImplementedException();
        }

        public override bool CanExecute()
        {
            if (!base.CanExecute()) return false;
            //TODO: implement
            throw new NotImplementedException();
        }

        public override bool CanExecute(WorldModel worldModel)
        {
            if (!base.CanExecute(worldModel)) return false;
            //TODO: implement
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            base.Execute();
            this.Character.GameManager.PickUpChest(this.Target);
        }

        public override void ApplyActionEffects(WorldModel worldModel)
        {
            base.ApplyActionEffects(worldModel);

            //TODO: implement
            throw new NotImplementedException();
        }
    }
}
