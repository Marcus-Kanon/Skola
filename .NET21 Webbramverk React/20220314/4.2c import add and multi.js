import { Add } from "./4.2a Add.js";
import { Multi } from "./4.2b Multi.js";

function combiner(a, b, c, d)
{
    return Add(a, Multi(b, c, d))
}

console.log(combiner(1,2,3,4));