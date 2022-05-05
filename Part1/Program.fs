// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

//Task 1

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





