module Problem1
(*
  If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
  The sum of these multiples is 23.

  Find the sum of all the multiples of 3 or 5 below 1000.
*)

let isMultipleOf factor value = value % factor = 0
let isMultipleOf3Or5 value = isMultipleOf 3 value || isMultipleOf 5 value

let solution = 
  [1 .. 999]
  |> List.filter isMultipleOf3Or5
  |> List.sum