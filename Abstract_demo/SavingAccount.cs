namespace Abstract_demo{
    internal class SavingAccount:Account{
        public float InterestRate { get; set; }
        public decimal Balance { get; set; }
       
        // public SavingAccount(){
        //     InterestRate = 8.5f;
        //     Balance=35000m;
        // }
 
        public SavingAccount(float intRate, decimal balance,int accId,Customer cust):base(accId,cust){
            InterestRate = intRate;
            Balance = balance;
        }
 
        public override void ShowBalance(){
            System.Console.WriteLine($"Saving Account Bal: {Balance:c}");
        }
 
        public override string ToString(){
            return $"Saving Account Details:{AccountId} {InterestRate} {Balance:c} {base.ToString()}";
        }
 
    }
}