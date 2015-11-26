using System;
using Assets.Scripts.GameManager;
using Assets.Scripts.IAJ.Unity.DecisionMaking.GOB;
using UnityEngine;

namespace Assets.Scripts.DecisionMakingActions
{
    public class GetArrows : WalkToTargetAndExecuteAction
    {
        public GetArrows(AutonomousCharacter character, GameObject target) : base("GetArrows",character,target)
        {
        }

        public override bool CanExecute()
        {
            if (!base.CanExecute()) return false;
            return this.Character.GameManager.characterData.Arrows < 10.0f;
        }

        public override bool CanExecute(WorldModel worldModel)
        {
            if (!base.CanExecute(worldModel)) return false;
            var arrows = (float)worldModel.GetProperty(Properties.ARROWS);
            return arrows < 10.0f;
        }

        public override void Execute()
        {
            base.Execute();
            this.Character.GameManager.GetArrows(this.Target);
        }


        public override void ApplyActionEffects(WorldModel worldModel)
        {
            base.ApplyActionEffects(worldModel);

            var arrows = (float)worldModel.GetProperty(Properties.ARROWS);
            worldModel.SetProperty(Properties.ARROWS, arrows + 10.0f);

            //disables the target object so that it can't be reused again
            worldModel.SetProperty(this.Target.name, false);
        }


    }
}
