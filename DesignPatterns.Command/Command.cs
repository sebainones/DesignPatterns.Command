namespace DesignPatterns.Command {
    public class Command {

        public Command (Action action, int amount) {
            this.Amount = amount;
            TheAction = action;

        }
        public enum Action {
            Deposit,
            Withdraw
        }

        public Action TheAction;
        public int Amount;
        public bool Success;

    }
}