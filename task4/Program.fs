// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
open System
open System.Threading

type Ticket = {seat:int; customer:string}
let mutable tickets = [for n in 1..10 -> {Ticket.seat = n; Ticket.customer = ""}]

let seatNo = ref 0
let name = ref ""

let bookSeat _ =
    lock (seatNo) (fun _ ->
    Console.WriteLine("Enter seat number: ")
    seatNo := int(Console.ReadLine())
  
    lock (name) (fun _ -> 
       Console.WriteLine("Enter customer name: ")
       name:= string(Console.ReadLine().ToString())
     
let book seatNo name tickets = 
        lock(seatNo,name) (fun()-> tickets |> List.map (fun ticket ->
            if ticket.seat = seatNo then { ticket with customer = name }
            else ticket ))    
    tickets <- book !seatNo !name tickets

ThreadPool.QueueUserWorkItem(new WaitCallback(bookSeat)) |> ignore
ThreadPool.QueueUserWorkItem(new WaitCallback(bookSeat)) |> ignore
Thread.Sleep(10000)

// My other attempts 
(*
let myLock = ref 1

type Ticket = {seat:int; customer:string}

let mutable ticket = [for n in 1..10 -> {Ticket.seat = n; Ticket.customer = ""}]

let DisplayTickets (x : Ticket list) =
    for n in x do 
        printfn "%d -> %s" n.seat n.customer


DisplayTickets ticket

let BookSeat _ =
    lock(myLock)(fun()->
                        Console.WriteLine("Please enter seat number")
                        let seat = Console.ReadLine() |> int
                        Console.WriteLine("Please enter your name")
                        let name = Console.ReadLine()
                        let newticket = {seat=seat; customer=name}
                        //list.map issue with bool
                        for n in ticket do 
                            if n.seat = seat then ticket.[seat] = newticket |>ignore 
                            else printfn "%s" "seat does not exist")
                        

ThreadPool.QueueUserWorkItem(new WaitCallback(BookSeat)) |> ignore

ThreadPool.QueueUserWorkItem(new WaitCallback(BookSeat)) |> ignore

Thread.Sleep(10000)

DisplayTickets ticket

*)

(*
    let bookSeat _ =
        lock (seat) (fun _ ->
          Console.WriteLine("Enter seat number: ")
          seatNo := int(Console.ReadLine())
        )
*)
    
(*
    open System
    open System.Threading
    
    type Ticket = {seat:int; customer:string}
    let mutable tickets = [for n in 1..10 -> {Ticket.seat = n; Ticket.customer = ""}]
    let bookSeat _ =
        Console.WriteLine("Enter seat number: ")
        let seatNo = int(Console.ReadLine())
        Console.WriteLine("Enter customer name: ")
        let name = string(Console.ReadLine())
        let book seatNo name tickets = 
            tickets |> List.map (fun ticket ->
                if ticket.seat = seatNo then { ticket with customer = name }
                else ticket )    
        tickets <- book seatNo name tickets

        let seatNo = ref 0
        let name = ref ""
        
        let bookSeat _ =
            Console.WriteLine("Enter seat number: ")
            seatNo :=  int(Console.ReadLine())
            Console.WriteLine("Enter customer name: ")
            name:= string(Console.ReadLine().ToString())
            let bookSeat _ =
              lock (seatNo) (fun _ ->
                Console.WriteLine("Enter seat number: ")
                seatNo := int(Console.ReadLine())
              )
              |>ignore
                lock (name) (fun _ -> 
                    Console.WriteLine("Enter customer name: ")
                    name:= string(Console.ReadLine().ToString()
                  
            |>ignore
            tickets <- book !seatNo !name tickets
        
        ThreadPool.QueueUserWorkItem(new WaitCallback(bookSeat)) |> ignore
        ThreadPool.QueueUserWorkItem(new WaitCallback(bookSeat)) |> ignore
        Thread.Sleep(5000)
*)


