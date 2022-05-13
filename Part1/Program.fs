// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
// Task One
type Account = {accountNumber:string 
                mutable balance:float}  
                member this.Deposit(money:float) = 
                    this.balance <- this.balance + money
                    Console.WriteLine($"You have added {money} to your account")
                    Console.WriteLine("Current Balance :" + this.balance.ToString("0.00"))
                member this.Withdraw(money:float) =
                    if money > this.balance then
                        Console.WriteLine("Unavailable funds, please check balance")
                    else 
                        this.balance <- this.balance - money
                        Console.WriteLine("Amount WithDrawn :" + money.ToString("0.00"))
                        Console.WriteLine("Current Balance :" + this.balance.ToString("0.00"))
                member this.Print =
                    Console.WriteLine(" - AccountNumber : " + this.accountNumber) 
                    Console.WriteLine(" - Account Balance :" + this.balance.ToString("0.00"))

let Acc1 = {accountNumber="0001"; balance=50.00}
let Acc2 = {accountNumber="0002"; balance=75.00} 
let Acc3 = {accountNumber="0003"; balance=100.00} 
let Acc4 = {accountNumber="0004"; balance=100.00} 
let Acc5 = {accountNumber="0005"; balance=10.00} 
let Acc6 = {accountNumber="0006"; balance=5.00} 

Acc2.Print
Acc2.Deposit 100.00
Acc2.Withdraw 200.00
Acc2.Withdraw 75.00
Acc1.Print 
Acc1.Withdraw 100.00
Acc1.Deposit 15.00
Acc1.Print





//I have left this in as this is what I presented orignially and was asked to change but leave in
//Task one attempt without using members that does not follow the breif with the functional approach
(*

let mutable balance = float(0)

//Print method for user welcome
Console.WriteLine("Welcome please Enter your account number")
let accountNumber = string(Console.ReadLine())
Console.WriteLine("Welcome  ")
Console.WriteLine(accountNumber)

//Print method to show the menu
let printMenu () = 
    printfn "Please select one of the folllwing options"
    printfn "1. Deposit Money"
    printfn "2. Show Balance"
    printfn "3. Withdraw Money"
let getInput () = Int32.TryParse (Console.ReadLine())

//Method to deposit money into the balance
let depositMoney () = 
    printfn "Deposit Money"
    printfn "Please Enter amount you wish to add (Numbers Only)"
    let a = float(Console.ReadLine())
    let b = float(0)
    let c = a + b
    balance <- c + balance
    printfn "%.2f" balance
    
//Method to show then balance of account 
let checkBalance (float) = 
    Console.WriteLine("Balance : ")
    printfn "%.2f" balance  

//Method to withdraw money from the account and check that the amount does not exceed the balance     
let withdrawMoney () = 
    Console.WriteLine("Balance of Account : ")
    Console.WriteLine(balance)
    Console.WriteLine("Please Enter the Amount you wish to Withdraw")
    let a = float(Console.ReadLine())
    let b = float(0)
    let c = float(a + b)
    if balance < c then Console.WriteLine("Unavailable funds, please check balance")
    elif a < float(0) then Console.WriteLine("Numbers Cannot be Negative")
    elif c <= balance then balance <- balance - c   

//Input error default message    
let menuPrint() =
    let menuString = "Please Enter a number between 1 and 3"
    Console.WriteLine(menuString)
        
//Menu Selection method
let rec menu ()=
    printMenu()
    match getInput() with 
    | true, 1 ->
        depositMoney()
        menu()
    |true, 2 ->
        checkBalance()
        menu()
    |true, 3 -> 
        withdrawMoney()
        menu()
    | _ -> 
        menuPrint()
        menu()

menu()
*)





