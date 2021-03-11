namespace PSBNebesky
{
    public partial class ServerComunicator
    {
        public enum Command
        {
            GetUserValidation,
            GetMoneyAmount,
            UserMoneyDeposit,
            UserMoneyWithdrawal,
            UserNewTransaction,
            UserTransactionHistory,
            UserInvalidate
        };
    }
}
