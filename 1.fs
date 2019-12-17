module Problem1

let isMultipleOf factor value = value % factor = 0
let isMultipleOf3Or5 value = isMultipleOf 3 value || isMultipleOf 5 value

let solution = 
  [1 .. 999]
  |> List.filter isMultipleOf3Or5
  |> List.sum