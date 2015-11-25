using System;
using Assets.Scripts.GameManager;
using Assets.Scripts.IAJ.Unity.DecisionMaking.GOB;
using Action = Assets.Scripts.IAJ.Unity.DecisionMaking.GOB.Action;

namespace Assets.Scripts.DecisionMakingActions
{
    public class Rest : Action
    {
        private AutonomousCharacter Character{ get; set; }

        public Rest(AutonomousCharacter character) : base("Rest")
        {
            this.Character = character;
            this.Duration = 0.5f;
        }

        public override float GetGoalChange(Goal goal)
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public override bool CanExecute()
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public override bool CanExecute(WorldModel worldModel)
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public override void ApplyActionEffects(WorldModel worldModel)
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            this.Character.GameManager.Rest();
        }
    }
}
