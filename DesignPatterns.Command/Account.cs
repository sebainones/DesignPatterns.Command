namespace DesignPatterns.Command {
    public class Account {
        public int Balance { get; set; }
        public void Process (Command c) {
            // todo
            if (c.TheAction == Command.Action.Deposit) {
                Balance += c.Amount;
                c.Success = true;
            } else if (c.TheAction == Command.Action.Withdraw) {
                if (Balance >= c.Amount) {
                    Balance -= c.Amount;
                    c.Success = true;

                } else
                    c.Success = false;
            }
        }
    }
}