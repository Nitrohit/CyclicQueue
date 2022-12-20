module CyclicQueue

type Value = int

let mutable q =  [||] 
let mutable first: int Option = None
let mutable last: int Option = None
let mutable size = 0

let create (n: int) : unit =
    
    q <- Array.init n (fun _ -> None)
    first <- Some 0
    last <- Some 0
    let mutable n = 1
    size <- n
    
    ()
    

(* Add an element to the end of a queue *)
let enqueue (e: Value) : bool =
    match last with
    | None -> false
    | Some l ->
        match q.[l] with
        | Some _ -> true
        | None ->
            q.[l] <- Some e
            last <- Some ((l + 1) % size)
            true

let dequeue () : Value Option =
    match first with
    | None -> None
    | Some f ->
        match q.[f] with
        | Some e ->
            q.[f] <- None
            first <- Some ((f + 1) % size)
            Some e
        | None -> None

let isEmpty () : bool =
    match first with
    | None -> false
    | Some f ->
        match last with
        | None -> false
        | Some l ->
            if f = l then
                match q.[f] with
                | Some _ -> false
                | None -> true
            else false
    






let length (): int =
    match first with
    | None -> 0
    | Some f ->
        match last with
        | None -> 0
        | Some l ->
            if f = l then
                match q.[f] with
                | Some _ -> 1
                | None -> 0
            else if f < l then
                l - f
            else
                size - f + l


let toString () : string =
    match first with
    | None -> ""
    | Some f ->
        match last with
        | None -> ""
        | Some l ->
            if f = l then
                match q.[f] with
                | Some e -> string e
                | None -> ""
            else if f < l then
                q.[f..(l-1)] |> Array.map (fun x -> match x with | Some e -> string e | None -> "None") |> Array.fold (fun s x -> s + x + " ") ""
            else
                q.[f..(size-1)] |> Array.append q.[0..(l-1)] |> Array.map (fun x -> match x with | Some e -> string e | None -> "None") |> Array.fold (fun s x -> s + x + " ") ""
    

